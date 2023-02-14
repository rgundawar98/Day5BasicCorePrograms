using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfNumber
    {
        public static void Calculate_Power()
        {
            double power = 1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
               power =power * 2;
               Console.WriteLine("2^{0}={1}",i,power);
            }
        }
    }
}
