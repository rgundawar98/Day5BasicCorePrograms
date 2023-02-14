using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public static void Check_Leap_Year()
        {
            Console.WriteLine("Enter the year to check leap or not");
            int year =Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Is not leap year");
            }
            else
            {
                Console.WriteLine("It is not leap year");
            }
        }
    }
}
