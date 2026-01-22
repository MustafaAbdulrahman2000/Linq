using Lecture_05.Models;
using System.Xml.Linq;

namespace Lecture_05.Extensions;

public static class ReverseExtensions
{
    public static IEnumerable<string> RunFirstReverseQuery(IEnumerable<string> source)
        => source.Reverse();
}
