using Lecture_05.Data;
using Lecture_05.Extensions;
using Lecture_05.Comparers;

var employees = EmployeeRepository.LoadEmployees();

// Order by Examples

string[] fruits ={ "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };

var orderedFruits = OrderByExtensions.RunFirstOrderByQuery(fruits);

orderedFruits.Print("Ordered Fruits (Alphabetic) ASC");

var orderedFruitsQS = OrderByExtensions.RunSecondOrderByQuery(fruits);

orderedFruitsQS.Print("Ordered Fruits (Alphabetic) ASC Query syntax");

var orderedFruitsDesc = OrderByExtensions.RunFirstOrderByDescendingQuery(fruits);

orderedFruitsDesc.Print("Ordered Fruits (Alphabetic) DESC");

var orderedFruitsQSDesc = OrderByExtensions.RunSecondOrderByDescendingQuery(fruits);

orderedFruitsQSDesc.Print("Ordered Fruits (Alphabetic) DESC Query syntax");

var orderedFruitsLengthDesc = OrderByExtensions.RunFirstOrderByDescendingByLengthQuery(fruits);

orderedFruitsLengthDesc.Print("Ordered Fruits (Length) DESC");

var orderedFruitsLengthQSDesc = OrderByExtensions.RunSecondOrderByDescendingByLengthQuery(fruits);

orderedFruitsLengthQSDesc.Print("Ordered Fruits (Length) DESC Query syntax");

var employeeComparer = new EmployeeComparer();

var orderedEmployeesByComparer = OrderByExtensions.RunOrderByWithCustomComparer(employees, employeeComparer); 

orderedEmployeesByComparer.Print("Ordered Employees by Custom Comparer");

// ThenBy Examples

var orderedEmployeesByNameAndSalary = ThenByExtensions.RunFirstThenByQuery(employees);

orderedEmployeesByNameAndSalary.Print("Ordered Employees by Name and Salary ASC");

var orderedEmployeesByNameAscAndSalaryDesc = ThenByExtensions.RunSecondThenByQuery(employees);

orderedEmployeesByNameAscAndSalaryDesc.Print("Ordered Employees by Name ASC and Salary DESC");

// Reverse Examples

var reversedFruits = ReverseExtensions.RunFirstReverseQuery(fruits);

reversedFruits.Print("Reversed Fruits");

Console.ReadKey();