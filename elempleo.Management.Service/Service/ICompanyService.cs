using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Service
{
    public interface ICompanyService
    {
        Task<ResponseDto<UserDto>> GetCompanyForUserId(int userId);
    }
}
