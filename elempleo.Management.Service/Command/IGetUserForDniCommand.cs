using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface IGetUserForDniCommand
    {
        Task<UserDto?> Execute(long dni);
	}
}
