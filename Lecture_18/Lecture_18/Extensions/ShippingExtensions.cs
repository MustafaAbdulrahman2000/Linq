using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class ShippingExtensions
{
    public static void Print<T>(this IEnumerable<T> source, string title) where T : Shipping
    {
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        
        foreach (var item in source)
            ((Shipping)item).Start();
    }
}
