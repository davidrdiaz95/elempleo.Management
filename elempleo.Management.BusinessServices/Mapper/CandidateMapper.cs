using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;

namespace elempleo.Management.BusinessServices.Mapper
{
    public static class CandidateMapper
    {
		public static CandidateDto MapFrom(this CandidateEntity model)
		{
			var candidate = new CandidateDto
			{
				Id = model.Id,
				Address = model.Address,
				Profile = model.Profile,
				Phone = model.Phone
			};
			return candidate;
		}

		public static CandidateEntity MapTo(this CandidateDto model)
		{
			var candidate = new CandidateEntity
			{
				Address = model.Address,
				Profile = model.Profile,
				Phone = model.Phone
			};
			return candidate;
		}
	}
}
