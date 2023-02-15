using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOddNumber
    {
        public static void Check_Number_Even_Odd()
        {
            Console.WriteLine("Enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("{0} is even number", Number);
            }
            else
            {
                Console.WriteLine("{0} is odd number", Number);
            }
        }
    }
}
