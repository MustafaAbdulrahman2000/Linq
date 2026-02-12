using Lecture_14.Models;

namespace Lecture_14.Extensions;

public static class AggregateExtensions
{
    public static string ConcatenateUsingAggregate(this IEnumerable<string> source) => source.Aggregate((previous, current) => $"{previous}, {current}");

    public static int SummationUsingAggregate(this IEnumerable<int> source) => source.Aggregate((previous, current) => previous + current);

    public static Question GetLongestQuestionTitleUsingAggregate(this IEnumerable<Question> quiz)
    {
        var longestQuestionTitle = quiz.ElementAt(0);

        longestQuestionTitle = quiz.Aggregate(longestQuestionTitle, (previous, current) => previous.Title!.Length < current.Title!.Length ? current : previous, q => q);

        return longestQuestionTitle;
    }
}
