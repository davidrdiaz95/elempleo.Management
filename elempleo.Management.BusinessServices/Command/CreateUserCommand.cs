using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class CreateUserCommand : ICreateUserCommand
	{
		private readonly IRepository<UserEntity> repository;
		private readonly IEncryptionCommand encryptionCommand;

		public CreateUserCommand(IRepository<UserEntity> repository,
			IEncryptionCommand encryptionCommand)
		{
			this.repository = repository;
			this.encryptionCommand = encryptionCommand;
		}

		public async Task<UserDto?> Execute(UserDto user)
		{
			var userEnty = user.MapTo();
			userEnty.DateCreate = DateTime.UtcNow;
			userEnty.Password = await this.encryptionCommand.Execute(user.Password);
			var insert = this.repository.Insert(userEnty);
			return insert > 0? userEnty.MapFrom() : null;
		}
	}
}
