namespace Lecture_18.Models;

public abstract class Shipping
{
    public string UniqueId { get; private set; } = string.Empty;
    public string Sender { get; private set; } = string.Empty;
    public DateTime ShippingDate { get; private set; }
    public abstract string Description { get; }

    protected Shipping(string uniqueId, string sender, DateTime shippingDate)
    {
        UniqueId = uniqueId;
        Sender = sender;
        ShippingDate = shippingDate;
    }

    public virtual void Start()
    {
        Console.WriteLine(
         $"\n\tCode: {UniqueId}" +
         $"\n\tDescription {Description}" +
         $"\n\tSender: {Sender}" +
         $"\n\tDate: {ShippingDate.ToShortDateString()}"
         );
    }
}