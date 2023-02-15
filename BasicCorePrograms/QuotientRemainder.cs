using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        public static void Calculation()
        {
            Console.WriteLine("Enter the dividend");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int Divisor= Convert.ToInt32(Console.ReadLine());
            int Quotient = Number/ Divisor;
            int Remainder = Number - (Divisor*Quotient);
            Console.WriteLine("Number:{0} and Quotient:{1} and Remainder:{2}",Number,Quotient,Remainder);
        }
    }
}
