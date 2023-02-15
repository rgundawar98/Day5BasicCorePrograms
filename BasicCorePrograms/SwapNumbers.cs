using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapNumbers
    {
        public static void Swap_Number_Using_Third_Var()
        {
            Console.WriteLine("Enter the number");
            int val1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            int val2=Convert.ToInt32(Console.ReadLine());
            int Temp = 0;
            Console.WriteLine("Before swapping numbers will be val1:{0}  and val2:{1}",val1,val2);
            Temp = val1 ;
            val1 = val2;
            val2 = Temp;
            Console.WriteLine("After swapping numbers will be val1:{0}  and val2:{1}", val1, val2);
        }
    }
}
