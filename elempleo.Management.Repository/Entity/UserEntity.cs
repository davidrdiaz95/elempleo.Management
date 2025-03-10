namespace elempleo.Management.Repository.Entity
{
	public class UserEntity : Base.Entity
	{
		public string FullName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
		public int IdRol { get; set; }
		public int IdTypeDni { get; set; }
		public long Dni { get; set; }
		public RolUserEntity? Rol { get; set; }
		public TypeDniEntity? TypeDni { get; set; }
		public CompanyEntity? Company { get; set; }
		public CandidateEntity? Candidate { get; set; }
	}
}
