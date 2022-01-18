using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    internal class LeapYear
    {

        public static void CalculateLeapYear()
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if(year.ToString().Length != 4)
            {
                Console.WriteLine("enter a valid 4 digit year");
            }
            else if(year % 400 == 0 || year % 4 == 0 && year  % 100 !=0)
            {
                Console.WriteLine("year :" + year + "is a leap year");
            }
            else
            {
                Console.WriteLine("year : " + year + " is not a leap year");
            }
        }
    }
}
