using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsInBiggerIntervals
{
    class SecondsInBiggerIntervals
    {
        static void Main(string[] args)
        {
            int seconds;
            int sec;
            int min;
            int hours;
            int days;

            seconds = int.Parse(Console.ReadLine());
            sec = seconds % 60;
            min = (seconds / 60) % 60;
            hours = ((seconds / 60) / 60) % 24;
            days = ((seconds / 60) / 60) / 24;

            System.Console.WriteLine(days + " days," + hours + " hours," + min + " minutes, " + sec + " seconds");

        }
    }
}
