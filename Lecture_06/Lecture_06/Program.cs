using Lecture_06.Data;
using Lecture_06.Extensions;

var employees = Repository.LoadEmployees();


// Examples of using Take. 

var first10Employees = employees.Take(10);

first10Employees.Print("First 10 employees");

var employeesBeforeOneWithSalary214400 = employees.TakeWhile(e => e.Salary != 214_400);

employeesBeforeOneWithSalary214400.Print("Employees before one with salary 214400");

var last10Employees = employees.TakeLast(10);

last10Employees.Print("Last 10 employees");

// Examples of using Skip.

var first10EmployeesSkipped = employees.Skip(10).Take(10);

first10EmployeesSkipped.Print("First 10 employees skipped");

var employeesAfterOneWithSalary214400 = employees.SkipWhile(e => e.Salary != 214_400);

employeesAfterOneWithSalary214400.Print("Employees after one with salary 214400");

var last10EmployeesSkipped = employees.SkipLast(10);

last10EmployeesSkipped.Print("Last 10 employees skipped");

// Examples of using Chunk.

var groupsOf10Employees = employees.Chunk(10).ToList();

for(int i = 0; i < groupsOf10Employees.Count; ++i)
    groupsOf10Employees[i].Print($"Group {i + 1} of 10 employees");


// Example of using Pagination.

int page = 1;

int pageSize = 10;

Console.Write("Please, enter number of employees in page: ");

if (int.TryParse(Console.ReadLine(), out var resultPerPage))
    pageSize = resultPerPage;

Console.Write("Please, enter number of page: ");

if (int.TryParse(Console.ReadLine(), out var pageNumber))
    page = pageNumber;

var pagedEmployees = employees.Paginate(page, pageSize);

var pageCount = pagedEmployees.Count();

var startRecord = (page - 1) * pageSize + 1;

var endRecord = pageCount < pageSize ? startRecord + pageCount - 1 : startRecord + pageSize - 1;

pagedEmployees.Print($"Showing employees {startRecord} - {endRecord}");

Console.ReadKey();