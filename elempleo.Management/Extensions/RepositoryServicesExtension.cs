using elempleo.Management.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace elempleo.Management.Extensions
{
	public static class RepositoryServicesExtension
	{
		public static void ConfigureDataBaseConnection(this IServiceCollection services, string connectionString)
		{
			services.AddDbContext<ContextDb>(options =>
			{
				options.UseSqlServer(connectionString);
			});
		}
	}
}
