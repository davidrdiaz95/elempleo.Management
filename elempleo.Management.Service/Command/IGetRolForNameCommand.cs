using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface IGetRolForNameCommand
    {
		Task<RolDto?> Execute(string name);
	}
}
