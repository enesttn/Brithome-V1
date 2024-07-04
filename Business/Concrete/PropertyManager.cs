using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete;

public class PropertyManager:IPropertyService
{
    IPropertyDal _propertyDal;

    public PropertyManager(IPropertyDal propertyDal)
    {
        _propertyDal = propertyDal;
    }

    public List<Property> GetAll()
    {
        return _propertyDal.GetAll();
    }
}
