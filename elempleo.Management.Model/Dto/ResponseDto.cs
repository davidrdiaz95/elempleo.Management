using System.Net;

namespace elempleo.Management.Model.Dto
{
	public class ResponseDto<T>
	{
		public List<string> Error { get; set; }

		public string Message { get; set; }

		public HttpStatusCode StatusCode { get; set; }

		public T Data { get; set; }
	}
}
