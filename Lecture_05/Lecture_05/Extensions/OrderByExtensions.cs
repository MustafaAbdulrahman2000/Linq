using Lecture_05.Comparers;
using Lecture_05.Models;

namespace Lecture_05.Extensions;

public static class OrderByExtensions
{
    public static IOrderedEnumerable<string> RunFirstOrderByQuery(IEnumerable<string> source)
        => source.OrderBy(f => f);

    public static IOrderedEnumerable<string> RunSecondOrderByQuery(IEnumerable<string> source)
        => from fruit in source
           orderby fruit
           select fruit;

    public static IOrderedEnumerable<string> RunFirstOrderByDescendingQuery(IEnumerable<string> source)
        => source.OrderByDescending(f => f);

    public static IOrderedEnumerable<string> RunSecondOrderByDescendingQuery(IEnumerable<string> source)
        => from fruit in source
           orderby fruit descending
           select fruit;

    public static IOrderedEnumerable<string> RunFirstOrderByDescendingByLengthQuery(IEnumerable<string> source)
         => source.OrderByDescending(f => f.Length);

    public static IOrderedEnumerable<string> RunSecondOrderByDescendingByLengthQuery(IEnumerable<string> source)
        => from fruit in source
           orderby fruit.Length descending
           select fruit;
    public static IOrderedEnumerable<Employee> RunOrderByWithCustomComparer(IEnumerable<Employee> source, EmployeeComparer employeeComparer)
        => source.OrderBy(e => e, employeeComparer);
}