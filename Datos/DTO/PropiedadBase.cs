using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.DTO
{
	public class PropiedadBase
	{
		public Guid Id { get; set; }
		public DateTime FechaCreacion { get; set; }
		public int Status { get; set; }
	}
}
