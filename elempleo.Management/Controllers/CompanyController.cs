using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace elempleo.Management.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	//[Authorize]
	public class CompanyController : ControllerBase
	{
		private readonly ICompanyService companyService;

		public CompanyController(ICompanyService companyService)
		{
			this.companyService = companyService;
		}

		[HttpGet]
		[Route("get-company")]
		public async Task<ResponseDto<UserDto>> GetCompanyForUserId(int userId)
		{
			var result = await this.companyService.GetCompanyForUserId(userId);
			return result;
		}
	}
}
