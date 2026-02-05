using Lecture_09.Data;
using Lecture_09.Dtos;

var departments = Repository.LoadDepartment();

var employees = Repository.LoadEmployees();

// Join example [method syntax]

var query = employees.Join(
    departments,
    emp => emp.DepartmentId,
    dept => dept.Id,
    (emp, dept) => new EmployeeDto
    {
        Name = emp.FullName,
        Department = dept.Name
    }); 

foreach(var employee in query)
    Console.WriteLine(employee);

// Join example [query syntax]

var query1 = from employee in employees
             join department in departments
             on employee.DepartmentId equals department.Id
             select new EmployeeDto
             {
                 Name = employee.FullName,
                 Department = department.Name
             };

foreach(var employee in query1)
    Console.WriteLine(employee);

// GroupJoin example [method syntax]

var query2 = departments.GroupJoin(
    employees,
    dept => dept.Id,
    emp => emp.DepartmentId,
    (dept, emp) => new
    {
        Department = dept.Name,
        Employees = emp.Select(e => e.FullName)
    });

foreach (var record in query2)
{
    Console.WriteLine($"================{record.Department}================");

    foreach (var employee in record.Employees)
        Console.WriteLine(employee);
}

// GroupJoin example [query syntax]

var query3 = from department in departments
             join employee in employees
             on department.Id equals employee.DepartmentId into empGroup
             select new
             {
                 Department = department.Name,
                 Employees = empGroup.Select(e => e.FullName)
             };

foreach (var record in query3)
{
    Console.WriteLine($"================{record.Department}================");

    foreach (var employee in record.Employees)
        Console.WriteLine(employee);
}

Console.ReadKey();