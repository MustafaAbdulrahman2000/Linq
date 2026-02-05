namespace Lecture_09.Dtos;

public class EmployeeDto
{
    public string? Name { get; set; }
    public string? Department { get; set; }

    public override string ToString()
    {
        return $"{Name} [{Department}]";
    }
}
