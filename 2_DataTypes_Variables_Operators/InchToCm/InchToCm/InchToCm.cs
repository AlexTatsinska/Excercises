using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchToCm
{
    class InchToCm
    {
        static void Main(string[] args)
        {
            float inch;
            float cm;
            inch = float.Parse(Console.ReadLine());
            cm = inch * 2.54f;

            System.Console.WriteLine(inch + " inch = " + cm + " cm");
        }
    }
}
