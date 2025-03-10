using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface ICreateCompanyCommand
    {
        Task<bool> Execute(CompanyDto company, int idUser);
	}
}
