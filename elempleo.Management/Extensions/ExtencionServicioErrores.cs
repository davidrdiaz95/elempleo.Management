using elempleo.Management.Middlewares;

namespace elempleo.Management.Extensions
{
	public static class ExtencionServicioErrores
	{
		public static void UseErrorHanldinMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<ErrorHandlerMiddleware>(Array.Empty<object>());
		}
	}
}
