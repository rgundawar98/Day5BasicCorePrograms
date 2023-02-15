using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public static void Count_Harmonic()
        {
            double val = 0;
            Console.WriteLine("Enter the number");
            double num =Convert.ToDouble(Console.ReadLine());
            for(double i=1;i<=num;i++)
            {
                val = val + 1 / i;
            }
             Console.WriteLine("1/{0}",val);
        }
    }
}
