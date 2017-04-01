using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0d_ReadNNumbers
{
    class Task0d_ReadNNumbers
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            int counter = 0;

            n = int.Parse(Console.ReadLine());
            m = Console.Read();

            while (counter < n)
            {
                if (m != 0)
                {
                    counter++;
                    System.Console.WriteLine((char)m);
                }
            }
        }
    }
}
