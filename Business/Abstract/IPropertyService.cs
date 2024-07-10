using Core.Utilities.Results;
using Entities;
using Entities.DTOs;


namespace Business.Abstract;

public interface IPropertyService
{
    IDataResult<List<Property>> GetAll();
    IDataResult<List<Property>> GetAllByCategoryId(int id);
    IDataResult<List<Property>> GetByPrice(decimal max, decimal min);
    IDataResult<List<PropertyDetailDto>> GetPropertyDetails();
    IDataResult<Property> GetById(int propertyId);
    IResult Add(Property property);
}
