using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class GetUserForDniCommand : IGetUserForDniCommand
	{
		private readonly IRepository<UserEntity> repository;

		public GetUserForDniCommand(IRepository<UserEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<UserDto?> Execute(long dni)
		{
			var user = this.repository.SingleFindBy(x => x.Dni == dni);
			return user?.MapFrom();
		}
	}
}
