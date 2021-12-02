using Datos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio.Interfaz
{
	public interface IOrden
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="IdPlatillo"></param>
		/// <returns></returns>
		Task<ICollection<ViewModelPlatillo>> ObtienOrden(Guid IdPlatillo);
	}
}
