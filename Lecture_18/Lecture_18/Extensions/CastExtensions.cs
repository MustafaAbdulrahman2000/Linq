using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class CastExtensions
{
    public static void RunCast<T>(IEnumerable<T> source) where T : Shipping
    {
        var groundShippings = source.Where(s => s.GetType() == typeof(GroundShipping))
                                    .Cast<GroundShipping>();

        groundShippings.Print("Ground shipping");
    }
}
