namespace Lecture_18.Models;

public class ShippingList<T> : List<T> where T : Shipping
{
    public IEnumerable<T> Where(Func<T, bool> predicate)
    {
        Console.WriteLine("Filtering shipping ...");

        return Enumerable.Where(this, predicate);
    }
}
