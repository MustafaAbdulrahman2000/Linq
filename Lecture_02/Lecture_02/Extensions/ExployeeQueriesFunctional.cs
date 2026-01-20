using Lecture_02.Models;

namespace Lecture_02.Extensions;

public class ExployeeQueriesFunctional
{
    public static IEnumerable<Employee> Filter(IEnumerable<Employee> source, Func<Employee, bool> predicate)
    {
        foreach (var employee in source)
            if (predicate(employee))
                yield return employee;
    }

    public static void Print<T>(IEnumerable<T> source, string title)
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
