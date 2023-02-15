using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Core Programs");
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.Flip Coin Percentage\n2.Leap Year\n3.Power Of Number\n4.Harmonic Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoinPercentage.Check_Percentage();
                    break;
                case 2:
                    LeapYear.Check_Leap_Year();
                    break;
                case 3:
                    PowerOfNumber.Calculate_Power();
                    break;
                case 4:
                    HarmonicNumber.Count_Harmonic();
                    break;
            }
        }
    }
}
