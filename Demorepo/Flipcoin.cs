using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    class Flipcoin
    {
        public static void flipCoinPercentage()
        {
            int tailCount = 0;
            int headCount = 0;
            Console.WriteLine("Please enter your numOfTimes");
            int  numOfTimes = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();


            for (int i = 1; i <= numOfTimes; i++)
            {
                double randomValue = random.NextDouble();
                if (randomValue < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Number of tails is" + tailCount + " out of " + numOfTimes);
            Console.WriteLine("Number of heads is" + headCount + " out of " + numOfTimes);
            double tailPercentage = Convert.ToDouble(tailCount * 100) / numOfTimes;
            Console.WriteLine(tailPercentage);
            double headPercentage = Convert.ToDouble(headCount * 100) / numOfTimes;
            Console.WriteLine(headPercentage);
        }
    }
}
