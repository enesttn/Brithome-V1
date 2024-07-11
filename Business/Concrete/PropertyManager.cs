using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;

namespace Business.Concrete;

public class PropertyManager : IPropertyService
{
    IPropertyDal _propertyDal;

    public PropertyManager(IPropertyDal propertyDal)
    {
        _propertyDal = propertyDal;
    }

    public IResult Add(Property property)
    {
        if (property.Title.Length < 2)
        {
            return new ErrorResult(Messages.PropertyTitleInvalid);
        }
        _propertyDal.Add(property);
        return new SuccessResult(Messages.PropertyAdded);
    }

    public IDataResult<List<Property>> GetAll()
    {
        if (DateTime.Now.Hour == 22)
        {

            return new ErrorDataResult<List<Property>>(Messages.MaintenanceTime);
        }


        return new SuccessDataResult<List<Property>>(_propertyDal.GetAll(), Messages.PropertiesListed);
    }

    public IDataResult<List<Property>> GetAllByCategoryId(int id)
    {
        return new SuccessDataResult<List<Property>>(_propertyDal.GetAll(p => p.CategoryID == id));
    }

    public IDataResult<Property> GetById(int propertyId)
    {
        return new SuccessDataResult<Property>(_propertyDal.Get(p => p.PropertyID == propertyId));
    }

    public IDataResult<List<Property>> GetByPrice(decimal max, decimal min)
    {

        return new SuccessDataResult<List<Property>>(_propertyDal.GetAll(p => p.Price >= min && p.Price <= max));
    }

    public IDataResult<List<PropertyDetailDto>> GetPropertyDetails()
    {
        //if (DateTime.Now.Hour == 00)
        //{

        //    return new ErrorDataResult<List<PropertyDetailDto>>(Messages.MaintenanceTime);
        //}
        return new SuccessDataResult<List<PropertyDetailDto>>(_propertyDal.GetPropertyDetails());
    }
}
