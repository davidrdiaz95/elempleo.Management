using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;

namespace elempleo.Management.BusinessServices.Mapper
{
    public static class CompanyMapper
    {
		public static CompanyDto MapFrom(this CompanyEntity model)
		{
			var company = new CompanyDto
			{
				Address = model.Address,
				Description = model.Description,
				Phone = model.Phone,
				Id = model.Id
			};
			return company;
		}

		public static CompanyEntity MapTo(this CompanyDto model)
		{
			var company = new CompanyEntity
			{
				Address = model.Address,
				Description = model.Description,
				Phone = model.Phone
			};
			return company;
		}
	}
}
