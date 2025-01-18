using Entities;

namespace Business.Abstract;

public interface IListingService
{
    List<Listing> GetAll();
    Listing GetById(int listingId);
}
