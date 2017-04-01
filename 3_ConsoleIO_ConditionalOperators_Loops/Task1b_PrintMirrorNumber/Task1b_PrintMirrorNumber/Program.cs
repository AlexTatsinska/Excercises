using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b_PrintMirrorNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string result = null;

            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                result = result + n % 10;
                n = n / 10;
            }

            System.Console.WriteLine(result);
        }
    }
}
