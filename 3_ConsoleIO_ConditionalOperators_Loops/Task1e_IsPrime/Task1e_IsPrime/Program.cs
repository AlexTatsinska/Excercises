using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1e_IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool check = false;

            n = int.Parse(Console.ReadLine());

            if ((n % 2 != 0) ||(n==2))
            {
                check = true;
            }

            System.Console.WriteLine(check);
        }
    }
}
