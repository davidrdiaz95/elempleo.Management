using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface ICreateUserCommand
    {
        Task<UserDto?> Execute(UserDto user);
    }
}
