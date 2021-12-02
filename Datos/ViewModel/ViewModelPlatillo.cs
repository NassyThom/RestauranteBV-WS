using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.ViewModel
{
	/// <summary>
	/// Modelo para mostrar el platillo
	/// </summary>
	public class ViewModelPlatillo
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
		public decimal Precio { get; set; }
		public decimal Peso { get; set; }
		public decimal Caloria { get; set; }
		public List<ViewModelIngrediente> Ingredientes { get; set; }
		
	}
}
