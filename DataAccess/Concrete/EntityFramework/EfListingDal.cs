using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;


namespace DataAccess.Concrete.EntityFramework;

public class EfListingDal:EfEntityRepositoryBase<Listing,BrithomeContext>,IListingDal
{
}
