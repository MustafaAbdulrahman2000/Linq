using Lecture_02.Data;
using Lecture_02.Extensions;

namespace Lecture_02.Services;

public class FunctionalQueryService : IQueryService
{
    public void Query()
    {
        var list = EmployeeRepository.LoadEmployees();

        var q1 = ExployeeQueriesFunctional.Filter(list, e => e.FirstName!.ToLowerInvariant().StartsWith("ma"));
        ExployeeQueriesFunctional.Print(q1, "Employees with first name starts with 'ma'");

        var q2 = ExployeeQueriesFunctional.Filter(list, e => e.FirstName!.ToLowerInvariant().EndsWith("ju"));
        ExployeeQueriesFunctional.Print(q2, "Employees with last name starts with 'ju'");

        var q3 = ExployeeQueriesFunctional.Filter(list, e => e.Department!.ToLowerInvariant() == "hr");
        ExployeeQueriesFunctional.Print(q3, "Employees in 'HR' department");

        var q4 = ExployeeQueriesFunctional.Filter(list, e => e.Gender!.ToLowerInvariant() == "female");
        ExployeeQueriesFunctional.Print(q4, "Female employees");

        var q5 = ExployeeQueriesFunctional.Filter(list, e => e.HireDate.Year == 2018);
        ExployeeQueriesFunctional.Print(q5, "Employees hired in '2018'");

        var q6 = ExployeeQueriesFunctional.Filter(list, e => e.HasPensionPlan);
        ExployeeQueriesFunctional.Print(q6, "Employees with Pension Plan");

        var q7 = ExployeeQueriesFunctional.Filter(list, e => !e.HasHealthInsurance);
        ExployeeQueriesFunctional.Print(q7, "Employees without Health insurance");

        var q8 = ExployeeQueriesFunctional.Filter(list, e => e.Salary == 107000);
        ExployeeQueriesFunctional.Print(q8, "Employees with Salary = $107000");

        var q9 = ExployeeQueriesFunctional.Filter(list, e => e.Salary > 107000);
        ExployeeQueriesFunctional.Print(q9, "Employees with Salary > $107000");

        var q10 = ExployeeQueriesFunctional.Filter(list, e => e.Salary < 107000);
        ExployeeQueriesFunctional.Print(q10, "Employees with Salary < $107000");

        var q11 = ExployeeQueriesFunctional.Filter(list, e => e.Salary < 107000 && e.Gender == "female");
        ExployeeQueriesFunctional.Print(q11, "Employees with Salary < $107000 and female");
    }
}
