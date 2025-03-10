using elempleo.Management.Model.Section;

namespace elempleo.Management.Extensions
{
	public static class MapSectionConfigServicesExtension
	{
		public static void ConfigureMapSectionConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			IConfigurationSection configuracionEncrypt = configuration.GetSection("Encrypt");
			services.Configure<EncryptSection>(configuracionEncrypt);
		}
	}
}
