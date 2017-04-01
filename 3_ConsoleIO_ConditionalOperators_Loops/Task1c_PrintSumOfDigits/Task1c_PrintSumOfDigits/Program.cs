using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1c_PrintSumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m = 0;

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                m = m + n % 10;
                n = n / 10;
            }

            System.Console.WriteLine(m);
        }
    }
}
