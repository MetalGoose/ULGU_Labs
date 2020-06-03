using System;

namespace lab3_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;
            Console.WriteLine(Sum(n));
            Console.ReadKey();
        }

        private static double Function(int n)
        {
            return (n - 1) / (Math.Pow(n, 3) + 3);
        }

        private static double Sum(int n)
        {
            double result = 0;
            
            for (int i = 1; i <= n; i++)
            {
                result += Function(i);
            }
            return result;
        }
    }
}
