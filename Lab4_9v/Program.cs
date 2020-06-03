using System;
using System.Threading;

namespace lab4_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Calculate()}");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Найти сумму таких элементов последовательности, которые меньше всех предшествующих им элементов.
        /// </summary>
        /// <returns></returns>
        private static double Calculate()
        {
            var rand = new Random();

            int? prevValue = null;
            int currValue;
            double sum = 0;

            while (true)
            {   
                currValue = rand.Next(0, 50);
                if (currValue == 0) break;

                if (prevValue == null)
                {
                    prevValue = currValue;
                    continue;
                }
                if (currValue < prevValue)
                {
                    sum += currValue;
                    prevValue = currValue;
                }
            }
            Thread.Sleep(100);
            return sum;
        }
    }
}
