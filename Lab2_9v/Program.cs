using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            const double A = -5; // От
            const double B = 5; // До
            const double H = 0.5; // Шаг
            const double n = 9; // Кол во строк в

            CreateTable(A,B,H,n);
            Console.ReadKey();
        }

        private static double Function(double x)
        {
            const double e = 2.71828;
            return x * Math.Pow(e, x) + 2 * Math.Sin(x) - Math.Sqrt(Math.Abs(Math.Pow(x,3) - Math.Pow(x, 2)));
        }

        private static void CreateTable(double from, double to, double step, double stepCount)
        {
            const double M = 263.019;
            var Rectangle = new int[,] { {-7, -6}, {-7, 5}, {3, 5}, {3, -6} };
            var values = new List<double>();
            var valuesInShape = 0;
            var n = 0;

            Console.WriteLine("x   |   y");
            for (var x = from; x <= to; x += step)
            {
                if (n > stepCount) break;

                var y = Function(x);
                Console.Write(Round(x) + "   |   " + Round(y) + "\n");
                values.Add(y);
                
                if (CheckValue(Rectangle, x, y)) valuesInShape++; 

                n++;
            }

            var avg = values.Average();
            Console.WriteLine($"Среднее арифметическое таких значений функции = {Round(avg)}" );
            Console.WriteLine($"Количество точек с координатами (x, y) из полученной таблицы попадает внутрь: {valuesInShape}");
        }

        private static bool CheckValue(int[,] rectangle, double x, double y)
        {
            var x1 = rectangle[0,0];
            var x2 = rectangle[2,0];
            var y1 = rectangle[0,1];
            var y2 = rectangle[1,1];

            if (x < x1 || x > x2) return false;
            if (y < y1 || y > y2) return false;
            return true;
        }

        static double Round(double x, int symbols = 4) => Math.Round(x, symbols);
    }
}
