using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_06.Models
{
    public class Employee
    {
        public int Index { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public decimal Salary { get; set; }
        public List<string> Skills { get; set; } = new();

        public override string ToString()
        {

            return
                    $"" +
                    $" {EmployeeNo!.PadRight(13, ' ')}\t" +
                    $" {Name!.PadRight(20, ' ')}\t" +
                    $" {Email!.PadRight(32, ' ')}\t" +
                    $" {String.Format("{0:C0}", Salary)}";
        }
    }
}
