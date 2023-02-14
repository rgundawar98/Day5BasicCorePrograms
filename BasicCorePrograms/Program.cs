using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Core Programs");
            Console.WriteLine("Choose option from below");
            Console.WriteLine("1.Flip Coin Percentage");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoinPercentage.Check_Percentage();
                    break;
            }
        }
    }
}
