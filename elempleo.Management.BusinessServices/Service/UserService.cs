using elempleo.Management.BusinessServices.Helper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Invoker;
using elempleo.Management.Services.Service;

namespace elempleo.Management.BusinessServices.Service
{
	public class UserService : IUserService
	{
		private readonly ICreateCompanyInvoker createCompanyInvoker;
		private readonly ICreateCandidateInvoker createCandidateInvoker;

		public UserService(ICreateCompanyInvoker createCompanyInvoker,
			ICreateCandidateInvoker createCandidateInvoker)
		{
			this.createCompanyInvoker = createCompanyInvoker;
			this.createCandidateInvoker = createCandidateInvoker;
		}

		public async Task<ResponseDto<string>> CreateCandidate(CreateCandidateDto createCompany)
		{
			var result = await this.createCandidateInvoker.Execute(createCompany);
			return result ?
				ResponseStatus.ResponseSucessful<string>("Se registro correctamente el usuario") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar el usuario");
		}

		public async Task<ResponseDto<string>> CreateCompany(CreateCompanyDto createCompany)
		{
			var result = await this.createCompanyInvoker.Execute(createCompany);
			return result ? 
				ResponseStatus.ResponseSucessful<string>("Se registro correctamente el usuario") :
				ResponseStatus.ResponseWithoutData<string>("No se pudo registrar el usuario");
		}
	}
}
