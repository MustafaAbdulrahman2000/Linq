namespace Lecture_18.Models;

public class AirShipping : Shipping
{
    public AirShipping(string uniqueId, string sender, DateTime shippingDate) : base(uniqueId, sender, shippingDate)
    {
    }
    public override string Description => "Air shipping";

}
