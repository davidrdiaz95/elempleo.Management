using elempleo.Management.Model.Dto;

namespace elempleo.Management.BusinessServices.Mapper
{
    public static class CreateCompanyMapper
    {
		public static CompanyDto MapToCompany(this CreateCompanyDto user)
		{
			return new CompanyDto
			{
				Address = user.Address,
				Phone = user.Phone,
				Description = user.Description
			};
		}

		public static UserDto MapToUser(this CreateCompanyDto user)
		{
			return new UserDto
			{
				Dni = user.Dni,
				FullName = user.FullName,
				IdTypeDni = user.IdTypeDni,
				Password = user.Password,
				UserName = user.UserName
			};
		}
	}
}
