using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio.Interfaz
{
	public interface IIngrediente
	{
		/// <summary>
		/// Obtiene el cátalogo de ingredientes
		/// </summary>
		/// <returns></returns>
		Task<List<string>> ObtieneIngredientes();
	}
}
