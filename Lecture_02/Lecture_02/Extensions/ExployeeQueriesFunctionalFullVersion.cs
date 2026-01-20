using Lecture_02.Models;

namespace Lecture_02.Extensions;

public static class ExployeeQueriesFunctionalFullVersion
{
    public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate)
    {
        foreach (var employee in source)
            if (predicate(employee))
                yield return employee;
    }

    public static void Print<T>(this IEnumerable<T> source, string title)
    {
        if (source == null)
            return;

        Console.WriteLine();
        Console.WriteLine("┌───────────────────────────────────────────────────────┐");
        Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
        Console.WriteLine("└───────────────────────────────────────────────────────┘");
        Console.WriteLine();

        foreach (var item in source)
            Console.WriteLine(item);
    }
}
