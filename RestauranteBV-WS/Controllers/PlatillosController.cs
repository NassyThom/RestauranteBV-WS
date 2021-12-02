using Common.Constraints;
using Common.HttpResponses;
using Datos.ViewModel;
using Microsoft.AspNetCore.Mvc;
using ModeloNegocio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteBV_WS.Controllers
{
	[Produces("application/json")]
	[Route("[controller]")]
	[ApiController]
	public class PlatillosController : ControllerBase
	{
		private readonly IOrden _orden;
		public PlatillosController(IOrden orden)
		{
			_orden = orden;
		}
		
		[HttpGet("ObtienePlatillo/{Id}")]
		[ProducesResponseType(typeof(HttpGenericResponse<DataNotPagedResponse<ViewModelPlatillo>>), 200)]
		[ProducesResponseType(typeof(HttpResponse), 204)]
		[ProducesResponseType(typeof(HttpResponse), 400)]
		[ProducesResponseType(typeof(HttpResponse), 403)]
		[ProducesResponseType(typeof(HttpResponse), 500)]
		public async Task<IActionResult> ObtenerMenu(Guid Id)
		{
			var result = await _orden.ObtienOrden(Id);
			if (result != null)
			{
				return Ok(new HttpGenericResponse<DataNotPagedResponse<ViewModelPlatillo>>(SystemCodes.Ok, new DataNotPagedResponse<ViewModelPlatillo>() { Content = result.ToList() }, false));
			}
			else
			{
				return StatusCode(200, new HttpResponse(SystemCodes.NoContent));
			}
		}
	}
}
