using Core.Entities;

namespace Entities;

public class Listing:IEntity
{
    public int ListingID { get; set; }
    public int PropertyID { get; set; }
    public int UserID { get; set; }
    public DateTime ListingDate { get; set; }
}
