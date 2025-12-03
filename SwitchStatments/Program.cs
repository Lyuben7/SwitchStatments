
using System;
namespace SwitchStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwitchStatements 

            //int day = 1;
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            string dayName;

            switch (day) 
            {
                case 1: dayName = "Monday"; break;
                case 2: dayName = "Tuesday"; break;
                case 3: dayName = "Wednesday"; break;
                case 4: dayName = "Thursday"; break;
                case 5: dayName = "Friday"; break;
                case 6: dayName = "Weekend"; break;
                default: dayName = "Invalid day"; break;
            }
            Console.WriteLine($"Today day is {dayName}");
        }
    }
}
