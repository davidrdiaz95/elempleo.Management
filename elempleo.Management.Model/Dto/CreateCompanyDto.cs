namespace elempleo.Management.Model.Dto
{
    public class CreateCompanyDto
    {
		public string FullName { get; set; }
		public long Dni { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int IdTypeDni { get; set; }
		public string Address { get; set; }
		public long Phone { get; set; }
		public string Description { get; set; }
	}
}
