using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.ViewModel
{
	public class ViewModelIngrediente
	{
		public Guid Id { get; set; }
		public string Nombre { get; set; }
		public ViewModelIngrediente()
		{
			Id = Guid.NewGuid();
			Nombre = "";
		}
	}
}
