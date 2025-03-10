using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface IGetCompanyForUserIdCommand
    {
        Task<UserDto> Execute(int userId);
	}
}
