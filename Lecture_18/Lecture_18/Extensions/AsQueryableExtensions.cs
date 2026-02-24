using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class AsQueryableExtensions
{
    public static void RunAsQueryable<T>(ShippingList<T> source) where T : Shipping
    {
        var todayShippingsUsingShippingListFiltering = source.Where(s => s.ShippingDate == DateTime.Today);

        todayShippingsUsingShippingListFiltering.Print("Today's shipping using ShippingList<T> Where");

        var todayShippingUsingIQueryableFiltering = source.AsQueryable().Where(s => s.ShippingDate == DateTime.Today);

        todayShippingUsingIQueryableFiltering.Print("Today's shipping using IEnumerable<T> Where");

        Console.WriteLine(todayShippingUsingIQueryableFiltering.Expression);
    }
}
