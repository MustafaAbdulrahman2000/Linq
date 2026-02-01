using Lecture_03.Data;
using Lecture_03.Extensions;

var employees = EmployeeRepository.LoadEmployees();


// Example usage of CompareFilterVsWhere

var filterEmployees = employees.CompareFilterVsWhere(e => e.Gender == "female" && e.FirstName!.ToLowerInvariant().StartsWith("s")).FilterEmployees;

var whereEmployees = employees.CompareFilterVsWhere(e => e.Gender == "female" && e.FirstName!.ToLowerInvariant().StartsWith("s")).WhereEmployess;

filterEmployees.Print("Filter Employees");

whereEmployees.Print("Where Employees");


// Example usage of GetEvenNumber

//List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

//var evenNumbersInMethodSyntax = numbers.GetEvenNumbers().Method;

//evenNumbersInMethodSyntax.Print("Even Numbers - Method Syntax");

//var evenNumbersInQuerySyntax = numbers.GetEvenNumbers().Query;

//evenNumbersInQuerySyntax.Print("Even Numbers - Query Syntax");

//var evenNumbersInBasicSyntax = numbers.GetEvenNumbers().Basic;

//evenNumbersInBasicSyntax.Print("Even Numbers - Basic Syntax");


// Example usage of where to filter employees

//var maleEmployees = employees.Where(e => e.Gender == "male");

//maleEmployees.Print("Male Employees");

//var employeesWithSalaryAbove300K = employees.Where(e => e.Salary > 300_000);

//employeesWithSalaryAbove300K.Print("Employees with Salary above 300K");

//var hrMaleEmployees = maleEmployees.Where(e => e.Department == "HR");

//hrMaleEmployees.Print("HR Male Employees");

Console.ReadKey();