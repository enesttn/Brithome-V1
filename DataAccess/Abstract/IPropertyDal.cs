using Core.DataAccess;
using Entities;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface IPropertyDal:IEntityRepository<Property>
{
    List<PropertyDetailDto> GetPropertyDetails();
}
