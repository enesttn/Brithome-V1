using Core.Entities;

namespace Entities;

public class ListingStatus:IEntity
{
    public int ListingStatusID { get; set; }
    public string StatusName { get; set; }

}
