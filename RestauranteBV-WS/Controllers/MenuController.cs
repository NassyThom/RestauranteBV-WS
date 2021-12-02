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
	public class MenuController : Controller
	{
		private readonly IMenu _menu;

		public MenuController(IMenu menu)
		{
			_menu = menu;
		}

		[HttpGet("ObtieneMenu")]
		[ProducesResponseType(typeof(HttpGenericResponse<DataNotPagedResponse<ViewModelMenu>>), 200)]
		[ProducesResponseType(typeof(HttpResponse),204)]
		[ProducesResponseType(typeof(HttpResponse),400)]
		[ProducesResponseType(typeof(HttpResponse),403)]
		[ProducesResponseType(typeof(HttpResponse),500)]
		public async Task<IActionResult> ObtenerMenu()
		{
			var result = await  _menu.ObtieneMenu();
			if (result!=null)
			{
				return Ok(new HttpGenericResponse<DataNotPagedResponse<ViewModelMenu>>(SystemCodes.Ok, new DataNotPagedResponse<ViewModelMenu>() { Content = result.ToList() }, false));
			}
			else
			{
				return StatusCode(200, new HttpResponse(SystemCodes.NoContent));
			}
		}

		
	}
}
