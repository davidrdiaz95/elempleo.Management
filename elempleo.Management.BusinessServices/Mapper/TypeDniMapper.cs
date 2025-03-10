using elempleo.Management.Model.Dto;
using elempleo.Management.Repository.Entity;

namespace elempleo.Management.BusinessServices.Mapper
{
    public static class TypeDniMapper
    {
		public static TypeDniDto MapFrom(this TypeDniEntity model)
		{
			var typeDni = new TypeDniDto
			{
				Id = model.Id,
				Name = model.Name,
			};
			return typeDni;
		}

		public static TypeDniEntity MapTo(this TypeDniDto model)
		{
			var typeDni = new TypeDniEntity
			{
				Id = model.Id,
				Name = model.Name,
			};
			return typeDni;
		}
	}
}
