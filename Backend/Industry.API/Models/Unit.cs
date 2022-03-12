

namespace Industry.API;

public class Unit : BaseFullModel<Guid>
{
    public Unit()
    {
        Product = new();
    }
    public string Name { get; set; }
    public virtual HashSet<Product> Product { get; set; }
}