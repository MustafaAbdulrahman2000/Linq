using Lecture_12.Data;
using Lecture_12.Models;

// SequenceEqual with the same parameters.


var firstQuestion = QuestionBank.PickOne();

var secondQuestion = QuestionBank.PickOne();

var thirdQuestion = QuestionBank.PickOne();

var firstQuiz = new List<Question>(new[] { firstQuestion, secondQuestion, thirdQuestion });

var secondQuiz = new List<Question>(new[] { firstQuestion, secondQuestion, thirdQuestion });

var equal = firstQuiz.SequenceEqual(secondQuiz);

Console.WriteLine($"The two quizzes are equal: {equal}");


// SequenceEqual with different parameters.


var randomFourQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4));

var firstQuizWithFourQuestions = randomFourQuestions;

var secondQuizWithFourQuestions = randomFourQuestions;

var equalWithFourQuestions = firstQuizWithFourQuestions.SequenceEqual(secondQuizWithFourQuestions);

Console.WriteLine($"The two quizzes with four questions are equal: {equalWithFourQuestions}");


// Override Equals and GetHashCode in the Question class to compare the content of the questions rather than their references.


var firstQuizWithOverrideMethods = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4));

var secondQuizWithOverrideMethods = QuestionBank.GetQuestionRange(Enumerable.Range(0, 4));

var equalWithOverrideMethods = firstQuizWithOverrideMethods.SequenceEqual(secondQuizWithOverrideMethods);

Console.WriteLine($"The two quizzes with overridden methods are equal: {equalWithOverrideMethods}");


Console.ReadKey();