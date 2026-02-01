using Lecture_06.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_06.Extensions
{
    public static class AdditionalExtensions
    {
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate)
        {
            foreach (var employee in source)
                if (predicate(employee))
                    yield return employee;
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            
            foreach (var item in source)
            {
                if (typeof(T).IsValueType)
                    Console.Write($" {item} "); // 1, 2, 3
                else
                    Console.WriteLine(item);
            }
        }

        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page = 1, int pageSize = 10)
            where T: class
        {
            if (page <= 0)
                page = 1;
            
            if (pageSize <= 0)
                pageSize = 10;

            var totalElements = source.Count();

            var pages = (int) Math.Ceiling((decimal)totalElements / pageSize);

            var result = source.Skip((page - 1) * pageSize).Take(pageSize);

            return result;
        }
    }
}