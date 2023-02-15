using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class CheckAlphabet
    {
        public static void Check_Alphabet()
        {
            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            string alphabet = " ";
            Console.WriteLine("Enter the alphabet");
            alphabet =Convert.ToString(Console.ReadLine());
            if ((alphabet == "a" || alphabet == "e" || alphabet == "i" || alphabet == "o" || alphabet == "u"
                || alphabet == "A" || alphabet == "E" || alphabet == "I" || alphabet=="O" || alphabet=="U"))
            {
                Console.WriteLine("Is Vowel:{0}", alphabet);
            }
            else
            {
                Console.WriteLine("Is Consonant :{0}", alphabet);
            }
        }
    }
}
