using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Service
{
    public interface IUserService
    {
        Task<ResponseDto<string>> CreateCompany(CreateCompanyDto createCompany);
		Task<ResponseDto<string>> CreateCandidate(CreateCandidateDto createCompany);
	}
}
