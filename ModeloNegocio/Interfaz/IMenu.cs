using Datos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio.Interfaz
{
	public interface IMenu
	{
		/// <summary>
		/// Obtiene el Menu con status 1 = Activos
		/// </summary>
		/// <returns></returns>
		Task<ICollection<ViewModelMenu>> ObtieneMenu();
	}
}
