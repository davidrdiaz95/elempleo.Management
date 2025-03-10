using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;

namespace elempleo.Management.BusinessServices.Mapper
{
	public static class RolMapper
	{
		public static RolDto MapFrom(this RolUserEntity model)
		{
			var rol = new RolDto
			{
				Id = model.Id,
				Name = model.Name,
			};
			return rol;
		}

		public static RolUserEntity MapTo(this RolDto model)
		{
			var rol = new RolUserEntity
			{
				Id = model.Id,
				Name = model.Name,
			};
			return rol;
		}
	}
}
