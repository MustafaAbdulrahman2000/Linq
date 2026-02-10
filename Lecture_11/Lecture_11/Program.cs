using Lecture_11.Data;
using Lecture_11.Extensions;
using Lecture_11.Models;

var questions = QuestionBank.All;


// ElementAt Example


var position = Convert.ToInt32(Console.ReadLine());

var questionAtPosition = questions.GetQuestionAtPosition(position);

if (questionAtPosition is not null)
    Console.WriteLine($"Question at position {position} is: {questionAtPosition.ToString()}");
else
    Console.WriteLine($"No question found at position {position}");


// First Examples


var firstQuestion = questions.GetFirstQuestionBasedOnPredicate(x => x.Title!.Contains("#"));

var otherFirstQuestion = new List<Question>().GetFirstQuestionBasedOnPredicate(x => x.Title!.Contains("#"));

if (firstQuestion is not null)
    Console.WriteLine($"First question is: {firstQuestion.ToString()}");
else
    Console.WriteLine("No first question found");


// Last Examples


var lastQuestion = questions.GetLastQuestion();

var lastQuestionBasedOnPredicate = questions.GetLastQuestionBasedOnPredicate(x => x.Title!.Contains("#"));

if (lastQuestion is not null)
    Console.WriteLine($"Last question is: {lastQuestion.ToString()}");
else
    Console.WriteLine("No last question found");

if (lastQuestionBasedOnPredicate is not null)
    Console.WriteLine($"Last question is: {lastQuestionBasedOnPredicate.ToString()}");
else
    Console.WriteLine("No last question found");


// Single Examples


var singleQuestion = questions.GetSingleQuestion(x => x.Title!.Contains("#1:"));

if (singleQuestion is not null)
    Console.WriteLine($"Single question is: {singleQuestion.ToString()}");
else
    Console.WriteLine("No single question found");


Console.ReadKey();