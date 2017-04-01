using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0c_ReadAge
{
    class Task0c_ReadAge
    {
        static void Main(string[] args)
        {
            int age;

            age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                System.Console.WriteLine("over 18");
            }
            else
            {
                System.Console.WriteLine("under 18");
            }

            
        }
    }
}
