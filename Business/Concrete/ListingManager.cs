using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class ListingManager : IListingService
    {
        private readonly IListingDal _listingDal;

        public ListingManager(IListingDal listingDal)
        {
            _listingDal = listingDal;
        }

        public List<Listing> GetAll()
        {
            return _listingDal.GetAll();
        }

        public Listing GetById(int listingId)
        {
            return _listingDal.Get(l => l.ListingID == listingId);
        }
    }
}
