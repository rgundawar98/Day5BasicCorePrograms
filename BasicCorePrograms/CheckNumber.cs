using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class CheckNumber
    {
        public static void Check_Big_Number()
        {
            Console.WriteLine("Enter the first number");
            int val1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int val3=Convert.ToInt32(Console.ReadLine());
            if(val1 > val2 && val1 >val3)
            {
                Console.WriteLine("{0} is greater", val1);
            }
            else if(val2>val1&& val2 >val3)
            {
                Console.WriteLine("{0} is greater", val2);
            }
            else
            {
                Console.WriteLine("{0} is greater",val3);
            }
        }
    }
}
