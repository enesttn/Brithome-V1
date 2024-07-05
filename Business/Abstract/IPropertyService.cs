using Entities;
using Entities.DTOs;


namespace Business.Abstract;

public interface IPropertyService
{
    List<Property> GetAll();
    List<PropertyDetailDto> GetPropertyDetails();
}
