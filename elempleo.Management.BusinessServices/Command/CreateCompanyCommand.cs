using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class CreateCompanyCommand : ICreateCompanyCommand
	{
		private readonly IRepository<CompanyEntity> repository;

		public CreateCompanyCommand(IRepository<CompanyEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(CompanyDto company, int idUser)
		{
			var companyEntity = company.MapTo();
			companyEntity.IdUser = idUser;
			companyEntity.DateCreate = DateTime.UtcNow;
			var result =  this.repository.Insert(companyEntity);
			return result > 0;
		}
	}
}
