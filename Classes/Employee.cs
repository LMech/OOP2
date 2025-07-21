using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Classes
{
    public class Employee
    {

        public int ID { get; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        public Employee(int id, string name, Gender gender,
                        SecurityLevel security, decimal salary, HireDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            // Format salary as currency using current culture :contentReference[oaicite:1]{index=1}
            string salaryStr = Salary.ToString("C", CultureInfo.CurrentCulture);
            return $"{ID,-3} | {Name,-15} | {Gender} | {Security,-15} | {salaryStr,10} | Hired: {HireDate.Day:D2}/{HireDate.Month:D2}/{HireDate.Year}";
        }
    }
}
