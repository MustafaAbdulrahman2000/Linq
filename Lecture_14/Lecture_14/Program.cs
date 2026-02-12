using Lecture_14.Data;
using Lecture_14.Extensions;


// Aggregate examples


var names = new[] { "Ali", "Salem", "Abeer", "Reem", "Jalal" };

var joinedNames = AggregateExtensions.ConcatenateUsingAggregate(names);

Console.WriteLine($"Names : {joinedNames.TrimEnd(",")}");

var numbers = new[] { 1, 2, 3, 4, 5 };

var sum = AggregateExtensions.SummationUsingAggregate(numbers);

Console.WriteLine($"Sum : {sum}\n\n");

var quiz = QuestionBank.All;

var questionWithLongestTitle = quiz.GetLongestQuestionTitleUsingAggregate();

Console.WriteLine($"Question with longest title :\n\n{questionWithLongestTitle}");


// Standard aggregate examples  


var questions = QuestionBank.GetQuestionRange(Enumerable.Range(0, 100));

var maximumMark = questions.GetMaximumMark();

Console.WriteLine($"Maximum mark : {maximumMark}");

var questionWithMaximumMark = questions.GetQuestionWithMaximumMark();

Console.WriteLine($"Question with maximum mark :\n\n{questionWithMaximumMark}");

var minimumMark = questions.GetMinimumMark();

Console.WriteLine($"Minimum mark : {minimumMark}");

var questionWithMinimumMark = questions.GetQuestionWithMinimumMark();

Console.WriteLine($"Question with minimum mark :\n\n{questionWithMinimumMark}");

var totalMarks = questions.GetTotalMarks();

Console.WriteLine($"Total marks : {totalMarks}");

var averageMarks = questions.GetAverageMarks();

Console.WriteLine($"Average marks : {averageMarks}");


Console.ReadKey();