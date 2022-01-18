using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    internal class QuotientAndRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            Console.WriteLine("Enter a dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : " +quotient);
            Console.WriteLine("Remainder is : " +remainder);
        }
    }
}