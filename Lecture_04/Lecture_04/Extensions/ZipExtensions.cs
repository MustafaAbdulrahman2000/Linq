using Lecture_04.Models;
using System.Xml.Linq;

namespace Lecture_04.Extensions;

public static class ZipExtensions
{
    public static IEnumerable<string> RunFirstZipQuery(IEnumerable<string> firstSource, IEnumerable<string> secondSource)
        => firstSource.Zip(secondSource, (name, hex) => $"{name} ({hex})");

    public static IEnumerable<string> RunSecondZipQuery(Employee[] source)
        => source[..3].Zip(source[^3..], (first, second) => $"{first.FirstName} With {second.FirstName}");
}
