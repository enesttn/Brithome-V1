using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

PropertyManager propertyManager = new(new EfPropertyDal());

foreach (var property in propertyManager.GetAll())
{
    Console.WriteLine(property.Title);
}