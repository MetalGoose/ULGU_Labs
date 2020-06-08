using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8_6v
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[5,7];
            var b = new List<int>();

            FillMatrix(a);
            MatrixPrettyPrint(a);
            b = Calculate(a);
            Console.Write("количество положительных элементов, делящихся на 5, каждой строки матрицы: ");
            b.ForEach((item) => Console.Write($" {item}"));
            Console.ReadKey();
        }

        /// <summary>
        /// Найти количество положительных элементов, делящихся на 5, каждой строки матрицы a(5, 7)
        /// и сохранить их в одномерном массиве b.
        /// </summary>
        static List<int> Calculate(int[,] matrix)
        {
            var result = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var count = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    var item = matrix[i, k];
                    if (item > 0 && item % 5 == 0) count++;
                }
                result.Add(count);
            }
            return result;
        }

        /// <summary>
        /// Заполняет матрицу случайными числами от -500 до 500
        /// </summary>
        /// <param name="matrix"></param>
        static void FillMatrix(int[,] matrix)
        {
            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = random.Next(-500, 500);
                }
            }
        }

        /// <summary>
        /// Вывод матрицы в консоль (в относительно красивом виде)
        /// </summary>
        /// <param name="matrix"></param>
        static void MatrixPrettyPrint(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i,j]} ");
                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
