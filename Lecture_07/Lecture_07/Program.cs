using Lecture_07.Extensions;
using Lecture_07.Services;

var employees = Repository.LoadEmployees();


// Examples of using Any.

var start = "jac";

var anyService = new AnyService(employees);

var hasEmployeeStartsWithValue = anyService.HasEmployeeWithNameStartingWith(start);

Console.WriteLine($"find employee with name starts with '{start}' result: {hasEmployeeStartsWithValue}");

var salary = 1000;

var hasEmployeeWithSalaryLess1000 = anyService.HasEmployeeWithSalaryLessThan1000(salary);

Console.WriteLine($"at least one employee with salary less than {salary.ToString("C2")} result: {hasEmployeeWithSalaryLess1000}");

var hasEmployeeWithOneSkill = anyService.HasEmployeeWithOneSkill();

Console.WriteLine($"at least one employee with one skill result: {hasEmployeeWithOneSkill}");


// Examples of using All.

var allService = new AllService(employees);

var allEmployeesHasDefinedEmail = allService.HasAllEmployeesWithEmailDefined();

Console.WriteLine($"all employees has defined email result: {allEmployeesHasDefinedEmail}");

var allEmployeesHasAtLeastOneSkill = allService.HasAllEmployeesWithAtLeastOneSkill();

Console.WriteLine($"all employees has at least one skill result: {allEmployeesHasAtLeastOneSkill}");

var allEmployeesHasSkillNode = allService.HasAllEmployeesHacingSkillNode();

Console.WriteLine($"all employees has skill node result: {allEmployeesHasSkillNode}");


// Examples of using Contains.

var containService = new ContainService(employees);

var sequence = "ee";

var hasEmployeeContainingSequenceInName = containService.HasEmployeeContainingSequenceInName(sequence);

Console.WriteLine($"find employee with name containing sequence '{sequence}' result: {hasEmployeeContainingSequenceInName}");

Console.ReadKey();