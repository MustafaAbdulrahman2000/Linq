namespace Lecture_18.Models;

public class RailShipping : Shipping
{
    public RailShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
    {
    }
    public override string Description => "Rail Shipping";

}