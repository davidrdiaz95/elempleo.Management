using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Constants;
using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Command;
using elempleo.Management.Services.Invoker;

namespace elempleo.Management.BusinessServices.Invoker
{
	public class CreateCandidateInvoker : ICreateCandidateInvoker
	{
		private readonly ICreateCandidateCommand createCandidateCommand;
		private readonly ICreateUserCommand createUserCommand;
		private readonly IGetUserForDniCommand getUserForDniCommand;
		private readonly IGetRolForNameCommand getRolForNameCommand;
		private readonly IGetUserForUserCommand getUserForUserCommand;

		public CreateCandidateInvoker(ICreateCandidateCommand createCandidateCommand,
			ICreateUserCommand createUserCommand,
			IGetUserForDniCommand getUserForDniCommand,
			IGetRolForNameCommand getRolForNameCommand,
			IGetUserForUserCommand getUserForUserCommand)
		{
			this.createCandidateCommand = createCandidateCommand;
			this.createUserCommand = createUserCommand;
			this.getUserForDniCommand = getUserForDniCommand;
			this.getRolForNameCommand = getRolForNameCommand;
			this.getUserForUserCommand = getUserForUserCommand;
		}

		public async Task<bool> Execute(CreateCandidateDto candidate)
		{
			var userExist = await getUserForDniCommand.Execute(candidate.Dni);
			if (userExist != null)
				throw new Exception("Un usuario con ese dni ya existe");

			userExist = await getUserForUserCommand.Execute(candidate.UserName);
			if (userExist != null)
				throw new Exception("Un usuario con ese user name ya existe");

			var userEnty = candidate.MapToUser();
			var company = candidate.MapToCandidate();

			var rol = await getRolForNameCommand.Execute(RolConstant.Candidate);
			userEnty.IdRol = rol.Id;
			userEnty.IdTypeDni = candidate.IdTypeDni;
			var newUser = await createUserCommand.Execute(userEnty);
			if (newUser == null)
				throw new Exception("No se pudo crear el usuario");

			var newCompany = await createCandidateCommand.Execute(company, newUser.Id);
			if (!newCompany)
				throw new Exception("No se pudo crear el usuario");

			return true;
		}
	}
}
