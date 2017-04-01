using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            short year;
            bool isLeapYear;
            year = short.Parse(Console.ReadLine());
            isLeapYear = ((year % 100 != 0) && (year % 4 == 0)) || ((year % 100 == 0) && (year % 400 == 0));

            System.Console.WriteLine(isLeapYear);
        }
    }
}
