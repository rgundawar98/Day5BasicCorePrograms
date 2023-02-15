using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactorization
    {
        public static void Check_Prime_factors()
        {
            int primeFactor = 2;
            Console.WriteLine("Enter the number");
            int value = Convert.ToInt32(Console.ReadLine());
            while(value >1)
            {
                if(value % primeFactor==0)
                {
                    Console.WriteLine("Prime Factor is :{0}", primeFactor);
                    value = value/ primeFactor;
                }
                else
                {
                    primeFactor++;
                }
            }
        }
    }
}
