using Business.Concrete;
using DataAccess.Concrete.EntityFramework;





PropertyTest();

//CategoryTest();

static void PropertyTest()
{
    PropertyManager propertyManager = new(new EfPropertyDal());

    var result = propertyManager.GetPropertyDetails();
    if (result.Success == true)
    {

        foreach (var property in result.Data)
        {
            Console.WriteLine(property.Title + "--" + property.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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