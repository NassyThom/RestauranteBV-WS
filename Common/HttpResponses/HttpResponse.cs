using Common.Constraints;
using System;

namespace Common.HttpResponses
{
	/// <summary>
	/// Respuesta HTTP Genérico
	/// </summary>
	public class HttpResponse
	{
		/// <summary>
		/// Codigo de Respuestas para personalizar
		/// </summary>
		public SystemCodes SystemCode { get; }
		/// <summary>
		/// Nombre del codigo de sistema
		/// </summary>
		public string SystemCodeName
		{
			get { return SystemCode.ToString(); }
		}		
		public Boolean ShowResponse { get; set; }
		/// <summary>
		/// Inicializa los atributos a utilizar
		/// </summary>
		/// <param name="systemcode"></param>
		/// <param name="showResponse"></param>
		public HttpResponse(SystemCodes systemcode, Boolean showResponse=true)
		{
			SystemCode = systemcode;
			ShowResponse = showResponse;
		}
	}
}
