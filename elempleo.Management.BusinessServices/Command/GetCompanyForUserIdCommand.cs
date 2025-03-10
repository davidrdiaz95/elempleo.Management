using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class GetCompanyForUserIdCommand : IGetCompanyForUserIdCommand
	{
		private readonly IRepository<UserEntity> repository;

		public GetCompanyForUserIdCommand(IRepository<UserEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<UserDto> Execute(int userId)
		{
			var user = this.repository.SingleFindByInclude(x => x.Id.Equals(userId), x => x.Company, x=> x.Candidate);
			return user.MapFrom();
		}
	}
}
