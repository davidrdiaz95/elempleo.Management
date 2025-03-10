using elempleo.Management.Model.Dto;
using elempleo.Management.Services.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace elempleo.Management.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		[HttpPost]
		[Route("create-company")]
		public async Task<IActionResult> CreateCompany(CreateCompanyDto createCompany)
		{
			var result = await this.userService.CreateCompany(createCompany);
			return result.StatusCode.Equals(HttpStatusCode.OK) ?
				Ok(result) :
				BadRequest(result);
		}

		[HttpPost]
		[Route("create-candidate")]
		public async Task<IActionResult> CreateCandidate(CreateCandidateDto createCandidate)
		{
			var result = await this.userService.CreateCandidate(createCandidate);
			return result.StatusCode.Equals(HttpStatusCode.OK) ?
				Ok(result) :
				BadRequest(result);
		}
	}
}
