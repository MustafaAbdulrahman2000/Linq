using Lecture_14.Models;

namespace Lecture_14.Extensions;

public static class StandardAggregateExtensions
{
    public static int GetMaximumMark(this IEnumerable<Question> quiz) => quiz.Max(q => q.Marks);
    public static Question GetQuestionWithMaximumMark(this IEnumerable<Question> quiz) => quiz.MaxBy(q => q.Marks)!;
    public static int GetMinimumMark(this IEnumerable<Question> quiz) => quiz.Min(q => q.Marks);
    public static Question GetQuestionWithMinimumMark(this IEnumerable<Question> quiz) => quiz.MinBy(q => q.Marks)!;
    public static int GetTotalMarks(this IEnumerable<Question> quiz) => quiz.Sum(q => q.Marks);
    public static double GetAverageMarks(this IEnumerable<Question> quiz) => quiz.Average(q => q.Marks);
}