using Dapper;
using Datos.Connection;
using Datos.ViewModel;
using ModeloNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModeloNegocio.Servicios
{
	public class OrdenService : IOrden
	{
		private readonly DapperContext _context;
		public OrdenService(DapperContext context)
		{
			_context = context;
		}
		/// <summary>
		/// Obtiene los platillos con detalle
		/// </summary>
		/// <param name="IdMenu"></param>
		/// <returns></returns>
		public async Task<ICollection<ViewModelPlatillo>> ObtienOrden(Guid IdMenu)
		{
			try
			{
				List<ViewModelPlatillo> listaPlatillos = new List<ViewModelPlatillo>();
				List<ViewModelIngrediente> listaPlatillosFiltrados = new List<ViewModelIngrediente>();

				List<ViewModelIngrediente> ingredientes = new List<ViewModelIngrediente>();
				var queryPlatillo = "SELECT Id, Nombre, Precio, Peso, Caloria FROM Adm_Platillo where CatMenuId=@IdMenu and  [Status]=1";


				using (var connection = _context.CreateConnection())
				{
					var sqlPlatillo = await connection.QueryAsync<ViewModelPlatillo>(queryPlatillo, new { IdMenu });
					listaPlatillos.AddRange(sqlPlatillo.ToList());
					foreach (var platillo in listaPlatillos)
					{
						var IdPlatillo = platillo.Id;
						var queryIngredeinte = "SELECT AP.Id as Id, CI.Nombre as Nombre from Adm_Platillo AP inner join " +
					"Rl_Platillo_Ingrediente RP on RP.AdmPlatilloId = AP.Id " +
					"inner join Cat_Ingrediente CI on CI.Id = RP.CatIngredienteId " +
					"where Ap.Id =@IdPlatillo and AP.[Status]= 1";
						var sqlIngrediente = await connection.QueryAsync<ViewModelIngrediente>(queryIngredeinte, new { IdPlatillo });
						ingredientes.AddRange(sqlIngrediente.ToList());

					}

				}
				for (int i = 0; i < listaPlatillos.Count; i++)
				{
					listaPlatillos[i].Ingredientes = ingredientes.Where(y => y.Id == listaPlatillos[i].Id).ToList();
				}
				return listaPlatillos;
			}
			catch (Exception ex)
			{
				//Guardar Log!
				return null;
			}

		}
	}
}
