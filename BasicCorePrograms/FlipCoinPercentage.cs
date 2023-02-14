using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoinPercentage
    {
        public static void Check_Percentage()
        {
            int HeadCount = 0 , TailCount=0;
            Console.WriteLine("Enter the value to flip the coin");
            int count = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for(int i=0;i<count; i++)
            {
                double input =random.NextDouble();
                if(input<0.5)
                {
                    HeadCount++;
                }
                else
                {
                    TailCount++;
                }
            }
            Console.WriteLine("HeadCount:{0}  and TailCount:{1}",HeadCount,TailCount);
            double HeadPercentage = (HeadCount * 100) / 10;
            double TailPercentage = (TailCount * 100) / 10;
            Console.WriteLine("HeadPercentage is {0}%",HeadPercentage);
            Console.WriteLine("TailPercentage is {0}%" ,TailPercentage);
        }
    }
}
