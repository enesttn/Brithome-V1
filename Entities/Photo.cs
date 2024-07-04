using Core.Entities;

namespace Entities;

public class Photo : IEntity
{
    public int PhotoID { get; set; }
    public int PropertyID { get; set; }
    public string PhotoUrl { get; set; }
    public string Description { get; set; }

}
