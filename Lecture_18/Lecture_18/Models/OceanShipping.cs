namespace Lecture_18.Models;

public class OceanShipping : Shipping
{
    public OceanShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
    {
    }
    public override string Description => "Ocean Shipping";

}
