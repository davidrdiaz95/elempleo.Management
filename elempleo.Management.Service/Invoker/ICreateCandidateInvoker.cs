using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Invoker
{
    public interface ICreateCandidateInvoker
    {
        Task<bool> Execute(CreateCandidateDto candidate);
	}
}
