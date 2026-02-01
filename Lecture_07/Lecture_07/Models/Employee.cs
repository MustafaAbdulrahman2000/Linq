using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_07.Models
{
    public class Employee
    {
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
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;

            else
            {
                Employee e = (Employee)obj;
                return (this.Email!.Equals(e.Email));
            }
        }

        public override int GetHashCode()
            => Email!.GetHashCode() + 13 * 7;
   
    }
}
