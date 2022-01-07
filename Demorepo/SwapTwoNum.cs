using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    internal class SwapTwoNum
    {
        public static void readInputFromUser()
        {
            Console.WriteLine("Please enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            swapNumbers(first, second);
        }

        public static void swapNumbers(int first, int second)
        {
            int temp = 0;
            Console.WriteLine("Before swapping first={0} second={1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("after swapping first={0} second={1}", first, second);
        }
    }
}
