using elempleo.Management.Model.Dto;

namespace elempleo.Management.Services.Invoker
{
    public interface ICreateCompanyInvoker
    {
        Task<bool> Execute(CreateCompanyDto user);
	}
}
