using Lecture_07.Models;

namespace Lecture_07.Services;

public class ContainService(IEnumerable<Employee> employees)
{
    // if any employee contains 'ee' in his/her name
    public bool HasEmployeeContainingSequenceInName(string sequence)
        => employees.Contains(employees.ToArray()[0]);

}