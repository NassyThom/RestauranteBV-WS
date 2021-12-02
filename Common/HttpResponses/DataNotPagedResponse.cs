using System.Collections.Generic;
using System.Linq;

namespace Common.HttpResponses
{
	/// <summary>
	/// Contenedor de datos no paginados
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class DataNotPagedResponse<T>
	{
		/// <summary>
		/// inicializa el contructor con contenedor vacío
		/// </summary>
		public DataNotPagedResponse()
		{
			Content = Enumerable.Empty<T>();
		}
		/// <summary>
		/// Inicializa el constructor con content
		/// </summary>
		/// <param name="content"></param>
		public DataNotPagedResponse(IEnumerable<T> content)
		{

			Content = content;
		}
		/// <summary>
		/// Contenedor de datos
		/// </summary>
		public IEnumerable<T> Content { get; set; }
	}
}
