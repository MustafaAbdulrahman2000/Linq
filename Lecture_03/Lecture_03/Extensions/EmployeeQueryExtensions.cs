using Lecture_03.Models;

namespace Lecture_03.Extensions;

public static class EmployeeQueryExtensions
{
    public static (IEnumerable<Employee> FilterEmployees, IEnumerable<Employee> WhereEmployess) CompareFilterVsWhere(this IEnumerable<Employee> source, Func<Employee, bool> predicate)
    {
        var filterEmployees = source.Filter(predicate);
        var whereEmployees = source.Where(predicate);

        return (filterEmployees, whereEmployees);
    }

    public static (IEnumerable<int> Method, IEnumerable<int> Query, IEnumerable<int> Basic) GetEvenNumbers(this IEnumerable<int> source)
    {
        var methodSyntax = source.Where(n => n % 2 == 0);
        
        var querySyntax = from number in source
                          where number % 2 == 0
                          select number;
        
        var basicSyntax = Enumerable.Where(source, n => n % 2 == 0);

        return (methodSyntax, querySyntax, basicSyntax);
    }


}
