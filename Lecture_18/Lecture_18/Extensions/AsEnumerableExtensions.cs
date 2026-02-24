using System.Linq;
using Lecture_18.Models;

namespace Lecture_18.Extensions;

public static class AsEnumerableExtensions
{
    public static void RunAsEnumerable<T>(ShippingList<T> source) where T : Shipping
    {
        var todayShippingsUsingShippingListFiltering = source.Where(s => s.ShippingDate == DateTime.Today);

        todayShippingsUsingShippingListFiltering.Print("Today's shipping using ShippingList<T> Where");

        var todayShippingUsingIEnumerableFiltering = source.AsEnumerable().Where(s => s.ShippingDate == DateTime.Today);

        todayShippingUsingIEnumerableFiltering.Print("Today's shipping using IEnumerable<T> Where");
    }
}