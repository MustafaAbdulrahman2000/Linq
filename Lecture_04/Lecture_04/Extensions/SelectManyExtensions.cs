using Lecture_04.Models;

namespace Lecture_04.Extensions;

public static class SelectManyExtensions
{
    public static IEnumerable<string> RunFirstSelectManyQuery(IEnumerable<string> source)
        => source.SelectMany(s => s.Split(' '));

    public static IEnumerable<string> RunSecondSelectManyQuery(IEnumerable<Employee> source)
        => source.SelectMany(e => e.Skills).Distinct();
    public static IEnumerable<string> RunThirdSelectManyQuery(IEnumerable<Employee> source)
        => (from employee in source
           from skill in employee.Skills
           select skill).Distinct();
}
