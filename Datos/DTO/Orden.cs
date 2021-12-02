using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.DTO
{
	public class Orden:PropiedadBase
	{
		public string Nombre { get; set; }
		public decimal Precio { get; set; }
		public decimal Peso { get; set; }
		public decimal Calorias { get; set; }
		public Guid CatMenuId { get; set; }
	}
}
