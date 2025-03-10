using elempleo.Management.BusinessServices.Mapper;
using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;
using elempleo.Management.Repository.Repositoty.Interface;
using elempleo.Management.Services.Command;

namespace elempleo.Management.BusinessServices.Command
{
	public class CreateCandidateCommand : ICreateCandidateCommand
	{
		private readonly IRepository<CandidateEntity> repository;

		public CreateCandidateCommand(IRepository<CandidateEntity> repository)
		{
			this.repository = repository;
		}

		public async Task<bool> Execute(CandidateDto candidate, int idUser)
		{
			var candidateEntity = candidate.MapTo();
			candidateEntity.IdUser = idUser;
			candidateEntity.DateCreate = DateTime.UtcNow;
			var result = this.repository.Insert(candidateEntity);
			return result > 0;
		}
	}
}
