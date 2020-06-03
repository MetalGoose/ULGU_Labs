using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            const double A = -5; // От
            const double B = 5; // До
            const double H = 0.1; // Шаг

            CreateTable(A,B,H);
            Console.ReadKey();
        }

        private static double Function(double x)
        {
            const double e = 2.71828;
            return x * Math.Pow(e, x) + 2 * Math.Sin(x) - Math.Sqrt(Math.Abs(Math.Pow(x,3) - Math.Pow(x, 2)));
        }

        private static void CreateTable(double from, double to, double step)
        {
            const double M = 263.019;
            var values = new List<double>();

            Console.WriteLine("x   |   y");
            for (var x = from; x <= to; x += step)
            {
                var y = Function(x);
                Console.Write(Round(x) + "   |   " + Round(y) + "\n");
                values.Add(y);
            }

            var avg = values.Where(y => y < M).Average();
            Console.WriteLine($"Среднее арифметическое таких значений функции, которые меньше числа {M}. = {Round(avg)}" );
        }

        static double Round(double x, int symbols = 4) => Math.Round(x, symbols);
    }
}
