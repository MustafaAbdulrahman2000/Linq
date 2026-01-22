using Lecture_04.Models;
using Lecture_04.Models.Dtos;

namespace Lecture_04.Extensions;

public static class SelectExtensions
{
    public static IEnumerable<string> RunFirstSelectQuery(IEnumerable<string> source)
        => source.Select(s => s.ToUpper());

    public static IEnumerable<int> RunSecondSelectQuery(IEnumerable<int> source)
        => source.Select(n => n * n);

    public static IEnumerable<EmployeeDto> RunThirdSelectQuery(IEnumerable<Employee> source)
        => source.Select(e => new EmployeeDto
        {
            Name = e.FullName,
            TotalSkills = e.Skills.Count
        });
}
