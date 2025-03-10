using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Command
{
    public interface ICreateCandidateCommand
    {
		Task<bool> Execute(CandidateDto candidate, int idUser);
	}
}
