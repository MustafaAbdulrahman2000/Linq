using Lecture_08.Data;
using Lecture_08.Extensions;

var employees = Repository.LoadEmployees();


// Examples of GroupBy.

var groupedEmployeesByDepartment = employees.GroupBy(e => e.Department);

foreach (var group in groupedEmployeesByDepartment)
    group.Print($"Employees in {group.Key} department");


// Examples of LookUp.

var groupedEmployeesByDepartmentByLookUp = employees.ToLookup(e => e.Department);

foreach (var group in groupedEmployeesByDepartmentByLookUp)
    group.Print($"Employees in {group.Key} department");


// Examples of GroupBy query syntax.

var groupedEmployeesByDepartmentQuerySyntax =
    from employee in employees
    group employee by employee.Department;

foreach (var group in groupedEmployeesByDepartmentQuerySyntax)
    group.Print($"Employees in {group.Key} department");

Console.ReadKey();