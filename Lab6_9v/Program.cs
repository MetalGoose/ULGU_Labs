using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            const int A = -28;
            const int B = 81;
            const int ArrayLenght = 30;

            var array = GetRandomArray(ArrayLenght, A, B);

            System.Console.Write("Массив до реверса: ");
            foreach (var item in array)
            {
                Console.Write($" {item} ");
            }
            array.Reverse();

            System.Console.Write("\nМассив после реверса: ");
            foreach (var item in array)
            {
                Console.Write($" {item} ");
            }

            System.Console.WriteLine($"\nМинимальный + максимальный элементы массива: {array.Min()} + {array.Max()} = {array.Min() + array.Max()}");
            Console.ReadKey();
        }

        /// <summary>
        /// Возвращает массив со случайными числами в указанном диапозоне
        /// </summary>
        /// <param name="arrayLenght">размер массива</param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        static List<int> GetRandomArray(int arrayLenght, int from, int to)
        {
            var rand = new Random(); 
            var array = new List<int>();

            for (int i = 0; i < arrayLenght; i++)
            {
                array.Add(rand.Next(from, to));
            }
            return array;
        }
    }
}
