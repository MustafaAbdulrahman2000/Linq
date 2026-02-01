using Lecture_04.Data;
using Lecture_04.Extensions;

var employees = EmployeeRepository.LoadEmployees();

// Select Examples

//List<string> words = new() { "i", "love", "asp.net", "core" };

//var upperWords = SelectExtensions.RunFirstSelectQuery(words);

//upperWords.Print("Capitalized Words");


//List<int> numbers = new() { 2, 3, 5, 7 };

//var powers = SelectExtensions.RunSecondSelectQuery(numbers);

//powers.Print("Power Of Numbers");


var employeesWithSkillsCount = SelectExtensions.RunThirdSelectQuery(employees);

employeesWithSkillsCount.Print("Customized Employees Data");

// SelectMany Examples

//string[] sentences = {
//                "I love asp.net core",
//                "I like sql server also",
//                "in general i love programming"
//            };

//var separatedWord = SelectManyExtensions.RunFirstSelectManyQuery(sentences);

//separatedWord.Print("Separated Words");

//var customizedEmployeesDataUsingMS = SelectManyExtensions.RunSecondSelectManyQuery(employees);

//customizedEmployeesDataUsingMS.Print("Customized Employees Data Using Method Syntax");

//var customizedEmployeesDataUsingQS = SelectManyExtensions.RunThirdSelectManyQuery(employees);

//customizedEmployeesDataUsingQS.Print("Customized Employees Data Using Query Syntax");

// Zip Examples

string[] colorName = { "Red", "Green", "Blue" };
string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };

var colors = ZipExtensions.RunFirstZipQuery(colorName, colorHEX);

colors.Print("Colors [name - hex]");

//var first3EmployeesWithLast3Employees = ZipExtensions.RunSecondZipQuery(employees.ToArray());

//first3EmployeesWithLast3Employees.Print("First 3 Employees With Last 3 Employees");