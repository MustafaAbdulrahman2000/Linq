using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class OfTypeExtensions
{
    public static void RunOftype<T>(IEnumerable<T> source) where T : Shipping
    {
        var groundShippings = source.OfType<GroundShipping>();

        groundShippings.Print("Ground shipping");
    }
}