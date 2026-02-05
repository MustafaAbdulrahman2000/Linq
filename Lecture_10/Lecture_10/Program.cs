using Lecture_10.Data;
using Lecture_10.Models;


// Empty example 

var emptyQuestionList = new List<Question>();

foreach (var question in emptyQuestionList)
    Console.WriteLine(question);

var emptyQuestionList2 = Enumerable.Empty<Question>();

foreach (var question in emptyQuestionList)
    Console.WriteLine(question);


// DefaultIfEmpty example

var emptyQuestionList3 = Enumerable.Empty<Question>();

var emptyQuestionList4 = emptyQuestionList3.DefaultIfEmpty();

var emptyQuestionList5 = emptyQuestionList3.DefaultIfEmpty(Question.Default);


Console.WriteLine(default(Object) is null ? "NULL" : default(Object) is null);

emptyQuestionList3.ToQuiz();


// Range example 

var range = Enumerable.Range(0, 20);

var questions = QuestionBank.GetQuestionRange(range);

questions.ToQuiz();


// Repeat example

var questions1 = new List<Question>();

for (int i = 0; i < 5; i++)
    questions1.Add(new Question());

Console.WriteLine(ReferenceEquals(questions1[0], questions1[1]));

var selectedQuestion = QuestionBank.PickOne();

var repeatedQuestions = Enumerable.Repeat(selectedQuestion, 10).ToList();

Console.WriteLine(ReferenceEquals(repeatedQuestions[0], repeatedQuestions[1]));

Console.ReadKey();
