using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Constants;
using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Command;
using elempleo.Management.Services.Invoker;

namespace elempleo.Management.BusinessServices.Invoker
{
	public class CreateCompanyInvoker : ICreateCompanyInvoker
	{
		private readonly ICreateCompanyCommand createCompanyCommand;
		private readonly ICreateUserCommand createUserCommand;
		private readonly IGetUserForDniCommand getUserForDniCommand;
		private readonly IGetRolForNameCommand getRolForNameCommand;
		private readonly IGetUserForUserCommand getUserForUserCommand;

		public CreateCompanyInvoker(ICreateCompanyCommand createCompanyCommand,
			ICreateUserCommand createUserCommand,
			IGetUserForDniCommand getUserForDniCommand,
			IGetRolForNameCommand getRolForNameCommand,
			IGetUserForUserCommand getUserForUserCommand)
		{
			this.createCompanyCommand = createCompanyCommand;
			this.createUserCommand = createUserCommand;
			this.getUserForDniCommand = getUserForDniCommand;
			this.getRolForNameCommand = getRolForNameCommand;
			this.getUserForUserCommand = getUserForUserCommand;
		}

		public async Task<bool> Execute(CreateCompanyDto user)
		{
			var userExist = await getUserForDniCommand.Execute(user.Dni);
			if (userExist != null)
				throw new Exception("Un usuario con ese dni ya existe");

			userExist = await getUserForUserCommand.Execute(user.UserName);
			if (userExist != null)
				throw new Exception("Un usuario con ese user name ya existe");

			var userEnty = user.MapToUser();
			var company = user.MapToCompany();

			var rol = await getRolForNameCommand.Execute(RolConstant.Company);
			userEnty.IdRol = rol.Id;
			userEnty.IdTypeDni = user.IdTypeDni;
			var newUser = await createUserCommand.Execute(userEnty);
			if (newUser == null)
				throw new Exception("No se pudo crear el usuario");

			var newCompany = await createCompanyCommand.Execute(company, newUser.Id);
			if (!newCompany)
				throw new Exception("No se pudo crear el usuario");

			return true;
		}
	}
}
