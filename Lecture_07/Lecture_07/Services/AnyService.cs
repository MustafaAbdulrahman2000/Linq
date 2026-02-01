using Lecture_07.Models;

namespace Lecture_07.Services;

public class AnyService(IEnumerable<Employee> employees)
{
    public bool HasEmployeeWithNameStartingWith(string start)
        => employees.Any(e => e.Name!.StartsWith(start, StringComparison.OrdinalIgnoreCase));

    public bool HasEmployeeWithSalaryLessThan1000(decimal salary)
        => employees.Any(e => e.Salary < salary);

    public bool HasEmployeeWithOneSkill()
        => employees.Any(e => e.Skills.Count == 1);
}
