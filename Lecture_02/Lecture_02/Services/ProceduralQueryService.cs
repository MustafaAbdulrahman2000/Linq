using Lecture_02.Extensions;

namespace Lecture_02.Services;

public class ProceduralQueryService : IQueryService
{
    public void Query()
    {
        var q1 = EmployeeQueriesProcedural.GetEmployeesWithFirstNameStartsWith("ma");
        EmployeeQueriesProcedural.Print(q1, "Employees with first name starts with 'ma'");

        var q2 = EmployeeQueriesProcedural.GetEmployeesWithLastNameStartsWith("ju");
        EmployeeQueriesProcedural.Print(q2, "Employees with last name starts with 'ju'");

        var q3 = EmployeeQueriesProcedural.GetEmployeesWithDepartmentEqualsTo("hr");
        EmployeeQueriesProcedural.Print(q3, "Employees in 'HR' department");

        var q4 = EmployeeQueriesProcedural.GetEmployeesByGender("female");
        EmployeeQueriesProcedural.Print(q4, "Female employees");

        var q5 = EmployeeQueriesProcedural.GetEmployeesHiredInYear(2018);
        EmployeeQueriesProcedural.Print(q5, "Employees hired in '2018'");

        var q6 = EmployeeQueriesProcedural.GetEmployeesWithPensionPlanValueEqualsTo(true);
        EmployeeQueriesProcedural.Print(q6, "Employees with Pension Plan");

        var q7 = EmployeeQueriesProcedural.GetEmployeesWithHealthInsuranceValueEqualsTo(false);
        EmployeeQueriesProcedural.Print(q7, "Employees without Health insurance");

        var q8 = EmployeeQueriesProcedural.GetEmployeesWithSalaryEqualsTo(103200);
        EmployeeQueriesProcedural.Print(q8, "Employees with Salary = $103200");

        var q9 = EmployeeQueriesProcedural.GetEmployeesWithSalaryGreaterThan(107000);
        EmployeeQueriesProcedural.Print(q9, "Employees with Salary > $107000");

        var q10 = EmployeeQueriesProcedural.GetEmployeesWithSalaryLessThan(107000);
        EmployeeQueriesProcedural.Print(q10, "Employees with Salary < $107000");
    }

}
