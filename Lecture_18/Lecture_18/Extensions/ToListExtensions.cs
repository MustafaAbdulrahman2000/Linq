using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class ToListExtensions
{
    public static void RunToList<T>(IEnumerable<T> source) where T: Shipping
    {
        var shippingList = source.ToList();

        Console.WriteLine($"Total shippings: {shippingList.Count}");
        
        Console.WriteLine($"Tirst shipping");
        
        shippingList[0].Start();
        
        shippingList.First().Start();
    }
}
