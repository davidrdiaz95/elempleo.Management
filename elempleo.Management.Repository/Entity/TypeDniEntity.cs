namespace elempleo.Management.Repository.Entity
{
    public class TypeDniEntity : Base.Entity
    {
		public string Name { get; set; }
		public IEnumerable<UserEntity> Users { get; set; }
	}
}
