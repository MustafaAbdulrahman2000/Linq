using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class ToDictionaryExtensions
{
    public static void RunToDictionary<T>(IEnumerable<T> source) where T : Shipping
    {
        var firstDictionary = source.ToDictionary(s => s.UniqueId);

        firstDictionary["ABC005"].Start();

        var secondDictionary = source.GroupBy(s => s.ShippingDate).ToDictionary(g => g.Key, g => g.ToList());

        var date = new DateTime(2026, 2, 24);

        secondDictionary[date].Print($"Shippings on {date.ToString("dddd, MMMM dd yyyy")}");
    }
}
