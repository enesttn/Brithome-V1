using Core.Entities;

namespace Entities;


public class Property : IEntity
{
    public int PropertyID { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public int NumRooms { get; set; }
    public int NumBathrooms { get; set; }
    public int NumBedrooms { get; set; }
    public decimal? Area { get; set; }
    public int CategoryID { get; set; }
    public int ListingStatusID { get; set; }
    public ListingStatus ListingStatus { get; set; }


}
