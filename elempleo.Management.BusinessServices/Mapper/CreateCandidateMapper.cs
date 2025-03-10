using elempleo.Management.Model.Dto;

namespace elempleo.Management.BusinessServices.Mapper
{
    public static class CreateCandidateMapper
    {
		public static CandidateDto MapToCandidate(this CreateCandidateDto user)
		{
			return new CandidateDto
			{
				Address = user.Address,
				Phone = user.Phone,
				Profile = user.Profile
			};
		}

		public static UserDto MapToUser(this CreateCandidateDto user)
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
