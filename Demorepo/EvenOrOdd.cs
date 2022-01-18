using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    internal class EvenOrOdd
    {
        public static void findEvenOrOdd()
        {
            Console.WriteLine("Enter a num ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("enter a positive num");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("number is even : " +num);
            }
            else
            {
                Console.WriteLine("number is odd : " + num);
            }
        }
    }
}
