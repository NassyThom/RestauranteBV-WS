using Dapper;
using Datos.Connection;
using Datos.ViewModel;
using ModeloNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio.Servicios
{
	public class MenuService : IMenu
	{
		private readonly DapperContext _context;
		public MenuService(DapperContext context)
		{
			_context = context;
		}


	
		/// <summary>
		/// Obtiene el Menu
		/// </summary>
		/// <returns></returns>
		public async Task<ICollection<ViewModelMenu>> ObtieneMenu()
		{
			var query = "SELECT Id, Nombre FROM Cat_Menu where [Status]=1";

			using (var connection = _context.CreateConnection())
			{
				var companies = await connection.QueryAsync<ViewModelMenu>(query);
				return companies.ToList();
			}
		}
	}
}
