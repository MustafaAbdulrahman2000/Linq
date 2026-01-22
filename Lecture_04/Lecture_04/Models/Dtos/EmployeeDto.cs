namespace Lecture_04.Models.Dtos;

public class EmployeeDto
{
    public string? Name { get; set; }
    public int TotalSkills { get; set; }

    public override string ToString() => $"{Name} ({TotalSkills})";
}
