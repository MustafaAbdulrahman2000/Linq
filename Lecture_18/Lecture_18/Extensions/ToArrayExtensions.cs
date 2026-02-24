using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class ToArrayExtensions
{
    public static void RunToArray<T>(IEnumerable<T> source) where T : Shipping
    {
        var shippingList = source.ToArray();

        Console.WriteLine($"Total shippings: {shippingList.Length}");

        Console.WriteLine($"Tirst shipping");

        shippingList[0].Start();

        shippingList.First().Start();
    }
}
