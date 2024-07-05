using Business.Concrete;
using DataAccess.Concrete.EntityFramework;





PropertyTest();

//CategoryTest();

static void PropertyTest()
{
    PropertyManager propertyManager = new(new EfPropertyDal());

    foreach (var property in propertyManager.GetPropertyDetails())
    {
        Console.WriteLine(property.Title + "--" + property.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}