using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface IGetUserForUserCommand
    {
		Task<UserDto?> Execute(string userName);
	}
}
