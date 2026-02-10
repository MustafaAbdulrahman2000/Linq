using Lecture_11.Models;

namespace Lecture_11.Extensions;

public static class ElementOperations
{
    public static Question? GetQuestionAtPosition(this IEnumerable<Question> questions, int position)
        => (position >= questions.Count()) ? questions.ElementAtOrDefault(position) : questions.ElementAt(position);

    public static Question? GetFirstQuestion(this IEnumerable<Question> questions)
        => questions.First();

    public static Question? GetFirstQuestionBasedOnPredicate(this IEnumerable<Question> questions, Func<Question, bool> predicate)
        => questions.FirstOrDefault(predicate);

    public static Question? GetLastQuestion(this IEnumerable<Question> questions)
        => questions.Last();

    public static Question? GetLastQuestionBasedOnPredicate(this IEnumerable<Question> questions, Func<Question, bool> predicate)
        => questions.LastOrDefault(predicate);

    public static Question? GetSingleQuestion(this IEnumerable<Question> questions, Func<Question, bool> predicate)
        => questions.SingleOrDefault(predicate);
}
