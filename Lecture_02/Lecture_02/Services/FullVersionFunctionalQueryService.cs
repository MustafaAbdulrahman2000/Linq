using Lecture_02.Data;
using Lecture_02.Extensions;

namespace Lecture_02.Services;

public class FullVersionFunctionalQueryService : IQueryService
{
    public void Query()
    {
        var list = EmployeeRepository.LoadEmployees();

        var q1 = list.Filter(e => e.FirstName!.ToLowerInvariant().StartsWith("ma"));
        q1.Print("Employees with first name starts with 'ma'");

        var q2 = list.Filter(e => e.LastName!.ToLowerInvariant().StartsWith("ju"));
        q2.Print("Employees with last name starts with 'ju'");

        var q3 = list.Filter(e => e.Department!.ToLowerInvariant() == "hr");
        q3.Print("Employees in 'HR' department");

        var q4 = list.Filter(e => e.Gender!.ToLowerInvariant() == "female");
        q4.Print("Female employees");

        var q5 = list.Filter(e => e.HireDate.Year == 2018);
        q5.Print("Employees hired in '2018'");

        var q6 = list.Filter(e => e.HasPensionPlan);
        q6.Print("Employees with Pension Plan");

        var q7 = list.Filter(e => !e.HasHealthInsurance);
        q7.Print("Employees without Health insurance");

        var q8 = list.Filter(e => e.Salary == 107000);
        q8.Print("Employees with Salary = $107000");

        var q9 = list.Filter(e => e.Salary > 107000);
        q9.Print("Employees with Salary > $107000");

        var q10 = list.Filter(e => e.Salary < 107000);
        q10.Print("Employees with Salary < $107000");

        var q11 = list.Filter(e => e.Salary < 107000 && e.Gender == "female");
        q11.Print("Employees with Salary < $107000 and female");
    }
}
