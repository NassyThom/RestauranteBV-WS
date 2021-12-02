using Common.Constraints;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HttpResponses
{
	/// <summary>
	/// Respuestas HTTP Genérico
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class HttpGenericResponse<T>: HttpResponse
	{
		/// <summary>
		/// Contenedor de datos Genérico
		/// </summary>
		public T Data { get; set; }
		/// <summary>
		/// Inicializa para el Response Genérico
		/// </summary>
		/// <param name="systemCode"></param>
		/// <param name="data"></param>
		/// <param name="showResponse"></param>
		public HttpGenericResponse(SystemCodes systemCode, T data, Boolean showResponse =true): base(systemCode,showResponse)
		{
			Data = data;
		}
	}
}
