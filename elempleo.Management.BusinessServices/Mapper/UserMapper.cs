using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;

namespace elempleo.Management.BusinessServices.Mapper
{
	public static class UserMapper
	{
		public static UserDto MapFrom(this UserEntity model)
		{
			var user = new UserDto
			{
				Id = model.Id,
				FullName = model.FullName,
				UserName = model.UserName,
				IdRol = model.IdRol,
				Dni = model.Dni,
				IdTypeDni = model.IdTypeDni,
				Rol = model.Rol?.MapFrom(),
				TypeDni = model.TypeDni?.MapFrom(),
				Company = model.Company?.MapFrom(),
				Candidate = model.Candidate?.MapFrom()
			};
			return user;
		}

		public static UserEntity MapTo(this UserDto model)
		{
			var user = new UserEntity
			{
				Id = model.Id,
				FullName = model.FullName,
				UserName = model.UserName,
				IdRol = model.IdRol,
				IdTypeDni = model.IdTypeDni,
				Dni = model.Dni
			};
			return user;
		}

		public static UserDto MapFirstFrom(this IEnumerable<UserEntity> model)
		{
			var user = new UserDto
			{
				Id = model.First().Id,
				FullName = model.First().FullName,
				UserName = model.First().UserName,
				IdRol = model.First().IdRol,
				Dni = model.First().Dni,
				IdTypeDni = model.First().IdTypeDni,
				Rol = model.First().Rol?.MapFrom(),
				TypeDni = model.First().TypeDni?.MapFrom()
			};
			return user;
		}
	}
}
