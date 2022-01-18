using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    internal class VowelsAndConsonants
    {
        public static void FindVowelOrConsonant()
        {
            char alphabet;
            Console.WriteLine("Enter a alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());
           
            if (alphabet == 'A' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine(alphabet + " is vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is a consonant");
            }
        }
    }
}
