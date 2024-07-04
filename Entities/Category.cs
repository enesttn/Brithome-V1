using Core.Entities;

namespace Entities;

public class Category:IEntity
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}

