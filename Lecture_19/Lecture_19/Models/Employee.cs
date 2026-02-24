namespace Lecture_19.Models;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public bool HasHealthInsurance { get; set; }
    public bool HasPensionPlan { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return
                string.Format($"" +
                $"{Id.ToString().PadRight(5, ' ')}\t" +
                $" {String.Concat(LastName, ", ", FirstName).PadRight(18, ' ')}\t" +
                $"{HireDate.Date.ToShortDateString()}\t" +
                $"{Gender.PadRight(3, ' ').PadRight(3, ' ')}\t" +
                $"{Department.PadRight(8, ' ')}\t" +
                $"{(HasHealthInsurance ? "Medical coverage" : "").PadRight(17, ' ')}\t" +
                $"{(HasPensionPlan ? "Pensionable" : "").PadRight(12, ' ')}\t" +
                $"{Salary:c0}");
    }
}
