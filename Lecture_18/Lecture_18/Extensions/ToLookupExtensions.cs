using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class ToLookupExtensions
{
    public static void RunToLookup<T>(IEnumerable<T> source) where T : Shipping
    {
        var firstLookup = source.ToLookup(s => s.UniqueId);

        firstLookup["ABC005"].First().Start();

        var secondLookup = source.ToLookup(s => s.ShippingDate);

        var date = new DateTime(2026, 2, 24);

        secondLookup[date].Print($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");
    }
}
