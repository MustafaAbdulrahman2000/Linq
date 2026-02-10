using Lecture_13.Data;
using Lecture_13.Models;


// Basic concatenation.


var firstQuiz = QuestionBank.Randomize(3);

var secondQuiz = QuestionBank.Randomize(2);

var fullQuiz = firstQuiz.Concat(secondQuiz);

fullQuiz.ToQuiz();


// Concatenation with extract features.


var otherFirstQuiz = QuestionBank.Randomize(3);

var otherSecondQuiz = QuestionBank.Randomize(2);

var otherFullQuiz = otherFirstQuiz.Select(q => q.Title).Concat(otherSecondQuiz.Select(q => q.Title));

foreach (var title in otherFullQuiz)
    Console.WriteLine(title);


// concatenation with method chaining.


var questionTitles =    QuestionBank.Randomize(3).Select(q => q.Title)
                        .Concat(QuestionBank.Randomize(2).Select(q => q.Title))
                        .Concat(QuestionBank.GetQuestionRange(Enumerable.Range(11, 14)).Select(q => q.Title));

foreach (var title in questionTitles)
    Console.WriteLine(title);


// concatenation using instantiation of a new collection.


var someFirstQuiz = QuestionBank.Randomize(3);

var someSecondQuiz = QuestionBank.Randomize(2);

var someFullQuiz = new [] { someFirstQuiz, someSecondQuiz }.SelectMany(q => q);

someFullQuiz.ToQuiz();


Console.ReadKey();