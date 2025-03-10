using elempleo.Management.Repository.Configuration;
using elempleo.Management.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace elempleo.Management.Repository.Context
{
	public class ContextDb : DbContext
	{
		public DbSet<UserEntity> User { get; set; }
		public DbSet<RolUserEntity> RolUser { get; set; }
		public DbSet<TypeDniEntity> TypeDni { get; set; }
		public DbSet<CompanyEntity> Company { get; set; }
		public DbSet<CandidateEntity> Candidate { get; set; }

		public ContextDb(DbContextOptions options) : base(options)
		{
		}

		public ContextDb()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
			modelBuilder.ApplyConfiguration(new RolUserEntityConfiguration());
			modelBuilder.ApplyConfiguration(new TypeDniEntityConfiguration());
			modelBuilder.ApplyConfiguration(new CompanyEntityConfiguration());
			modelBuilder.ApplyConfiguration(new CandidateEntityConfiguration());
		}
	}
}
