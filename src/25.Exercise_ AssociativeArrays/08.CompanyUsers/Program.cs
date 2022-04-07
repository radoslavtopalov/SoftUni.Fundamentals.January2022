using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(' ');
            var companies = new Dictionary<string, List<string>>();

            while (command[0] != "End")
            {
                var company = command[0].Trim();
                var employeeId = command[2].Trim();

                if (companies.ContainsKey(company))
                {
                    if (!companies[company].Contains(employeeId))
                    {
                        companies[company].Add(employeeId);
                    }
                }
                else
                {
                    companies.Add(company, new List<string> { employeeId });
                }

                command = Console.ReadLine().Split(' ');
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var v in company.Value)
                {
                    Console.WriteLine($"-- {v}");
                }
            }
        }
    }
}