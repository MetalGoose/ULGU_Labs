using System;
using System.Collections.Generic;
using System.Linq;

namespace lab5_9v
{
    class Program
    {
        static void Main(string[] args)
        {
            const int A = -28;
            const int B = 81;
            const int ArrayLenght = 30;

            var array = GetRandomArray(ArrayLenght, A, B);

            System.Console.Write("Элементы массива: ");
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine($"Минимальный элемент: {array.Min()}");
            System.Console.WriteLine($"Количество минимальных элементов: {Calculate(array)}");
        }

        static int Calculate(List<int> array)
        {
            var minValue = array.Min();
            return array.Where(a => a == minValue).Count();
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
