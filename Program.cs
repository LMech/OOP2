using OOP2.Classes;

namespace OOP2
{
    internal class Program
    {
        static void Main()
        {
            var EmpArr = new Employee[]
                   {
            new Employee(1, "Alice", Gender.F, SecurityLevel.DBA, 5000m,
                         new HireDate(5, 3, 2020)),
            new Employee(2, "Bob", Gender.M, SecurityLevel.Guest, 3000m,
                         new HireDate(12, 7, 2019)),
            new Employee(3, "Carol", Gender.F, SecurityLevel.SecurityOfficer, 7000m,
                         new HireDate(1, 1, 2021))
                   };

            // Sort by HireDate (uses IComparable from HireDate class)
            Array.Sort(EmpArr, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

            Console.WriteLine("Sorted Employees by Hire Date:");
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

            // Boxing/unboxing count:
            // - Enums are value types. When calling ToString() or comparing, they may be boxed.
            // - In this code, each employee's Gender and Security enum values get boxed once
            //   during string interpolation in ToString().
            // -> Total boxing: 2 enums per employee × 3 employees = 6 boxing operations.        }
        }
    }
}
