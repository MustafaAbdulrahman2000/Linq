using Lecture_07.Models;

namespace Lecture_07.Services;

public class AllService(IEnumerable<Employee> employees)
{
    // if all employees have email defined
    public bool HasAllEmployeesWithEmailDefined()
        => employees.All(e => !string.IsNullOrWhiteSpace(e.Email));

    // if all employees have at least 1 skill
    public bool HasAllEmployeesWithAtLeastOneSkill()
        => employees.All(e => e.Skills.Count >= 1);

    // if all employees having skill node
    public bool HasAllEmployeesHacingSkillNode()
        => (from employee in employees
           where employee.Skills.All(s => s.Contains("node", StringComparison.OrdinalIgnoreCase))
           select employee).Count() == employees.Count();
}
