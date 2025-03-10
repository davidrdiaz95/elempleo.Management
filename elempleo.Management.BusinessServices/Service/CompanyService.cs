using elempleo.Management.BusinessServices.Helper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Command;
using elempleo.Management.Services.Service;

namespace elempleo.Management.BusinessServices.Service
{
	public class CompanyService : ICompanyService
	{
		private readonly IGetCompanyForUserIdCommand getCompanyForUserIdCommand;

		public CompanyService(IGetCompanyForUserIdCommand getCompanyForUserIdCommand)
		{
			this.getCompanyForUserIdCommand = getCompanyForUserIdCommand;
		}

		public async Task<ResponseDto<UserDto>> GetCompanyForUserId(int userId)
		{
			var result = await this.getCompanyForUserIdCommand.Execute(userId);
			return result != null?
				ResponseStatus.ResponseSucessful<UserDto>(result) :
				ResponseStatus.ResponseWithoutData<UserDto>("No se encontro la empresa");
		}
	}
}
