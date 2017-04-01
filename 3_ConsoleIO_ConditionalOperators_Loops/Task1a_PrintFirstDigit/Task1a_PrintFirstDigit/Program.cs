using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a_PrintFirstDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());

            while (n > 10)
            {
                n = n / 10;
            }

            System.Console.WriteLine(n);
        }
    }
}
