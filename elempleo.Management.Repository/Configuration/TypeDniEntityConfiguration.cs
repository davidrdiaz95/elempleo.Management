using elempleo.Management.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace elempleo.Management.Repository.Configuration
{
	public class TypeDniEntityConfiguration : IEntityTypeConfiguration<TypeDniEntity>
	{
		public void Configure(EntityTypeBuilder<TypeDniEntity> builder)
		{
			builder.ToTable("TypeDni");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).HasColumnName("id");
			builder.Property(x => x.Name).HasColumnName("name_type");
			builder.Property(x => x.DateCreate).HasColumnName("date_create");
			builder.Property(x => x.IdUserUpdate).HasColumnName("fk_id_user_update");
			builder.Property(x => x.DateUpdate).HasColumnName("date_update");
		}
	}
}
