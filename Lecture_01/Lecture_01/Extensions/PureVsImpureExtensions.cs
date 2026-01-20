namespace Lecture_01.Extensions;

public static class PureVsImpureExtensions
{
    public static void Print(this List<int> source)
    {
        foreach (var item in source)
            Console.Write($" {item}");
        
        Console.WriteLine();
    }
}
