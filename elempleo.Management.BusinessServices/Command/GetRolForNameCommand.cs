using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class GetRolForNameCommand : IGetRolForNameCommand
	{
		private readonly IRepository<RolUserEntity> repository;

		public GetRolForNameCommand(IRepository<RolUserEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<RolDto?> Execute(string name)
		{
			var rol = this.repository.SingleFindBy(x => x.Name == name);
			return rol?.MapFrom();
		}
	}
}
