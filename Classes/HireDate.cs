using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Classes
{
    public class HireDate : IComparable<HireDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            // Basic validation to avoid runtime errors
            Day = Math.Clamp(day, 1, 31);
            Month = Math.Clamp(month, 1, 12);
            Year = Math.Max(1900, year);
        }

        public DateTime ToDateTime() => new DateTime(Year, Month, Day);

        public int CompareTo(HireDate other)
            => ToDateTime().CompareTo(other.ToDateTime());
    }
}
