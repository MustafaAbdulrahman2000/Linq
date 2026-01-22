using Lecture_05.Models;

namespace Lecture_05.Extensions;

public static class ThenByExtensions
{
    public static IOrderedEnumerable<Employee> RunFirstThenByQuery(IEnumerable<Employee> source)
        => source.OrderBy(e => e.Name).ThenBy(e => e.Salary);

    public static IEnumerable<Employee> RunSecondThenByQuery(IEnumerable<Employee> source)
        => source.OrderBy(e => e.Name).ThenByDescending(e => e.Salary);
}
