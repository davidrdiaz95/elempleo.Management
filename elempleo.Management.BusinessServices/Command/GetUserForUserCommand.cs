using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class GetUserForUserCommand : IGetUserForUserCommand
	{
		private readonly IRepository<UserEntity> repository;
		public GetUserForUserCommand(IRepository<UserEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<UserDto?> Execute(string userName)
		{
			var user = this.repository.SingleFindBy(x => x.UserName == userName);
			return user?.MapFrom();
		}
	}
}
