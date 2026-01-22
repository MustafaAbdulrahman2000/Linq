using Lecture_05.Models;

namespace Lecture_05.Comparers;

public class EmployeeComparer : IComparer<Employee>
{
    public int Compare(Employee? first, Employee? second)
    {
        var firstEmployeeYear = first!.EmployeeNo!.Split('-')[0];
        
        var secondEmployeeYear = second!.EmployeeNo!.Split('-')[0];

        var firstEmployeeSequence = Convert.ToInt32(first.EmployeeNo!.Split('-')[2]);
        
        var secondEmployeeSequence = Convert.ToInt32(second.EmployeeNo!.Split('-')[2]);

        return (firstEmployeeYear == secondEmployeeYear) ?
            firstEmployeeSequence.CompareTo(secondEmployeeSequence) :
            firstEmployeeYear.CompareTo(secondEmployeeYear);
    }
}
