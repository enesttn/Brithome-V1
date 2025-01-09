using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfPropertyDal : EfEntityRepositoryBase<Property, BrithomeContext>, IPropertyDal
{
    public List<PropertyDetailDto> GetPropertyDetails()
    {
        using (BrithomeContext context = new())
        {
            var result = from p in context.Properties
                         join c in context.Categories
                         on p.CategoryID equals c.CategoryID
                         join s in context.ListingStatuses 
                         on p.ListingStatusID equals s.ListingStatusID
                         select new PropertyDetailDto
                         {
                             PropertyID = p.PropertyID,
                             Title = p.Title,
                             CategoryName = c.CategoryName,
                             City = p.City,
                             Status = s.StatusName 
                         };
            return result.ToList();
        }
    }
}

