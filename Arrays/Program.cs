//#define ARRAYS_1
//#define ARRAYS_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random random = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100, 200);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            foreach (int i in arr) // цикл для работы с массивами
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Сумма:" + " " + arr.Sum());
            Console.WriteLine("AVG:" + " " + arr.Average());
            Console.WriteLine("min:" + " " + arr.Min());
            Console.WriteLine("max:" + " " + arr.Max());
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); 
#endif
#if ARRAYS_2
            Random random = new Random(0);

            Console.WriteLine("Введите количество строк:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов строки: ");
            int cols = Convert.ToInt32(Console.ReadLine());


            int[,] arr = new int[rows, cols]; // запятая разделяет cols and rows  два измерения 
            Console.WriteLine($"Количество измерений массива: {arr.Rank}");
            Console.WriteLine($"Количество строк массива: {arr.GetLength(1)}");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(100);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            foreach (int i in arr) // выводит двумерный массив в одну строчку 
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива: {arr.Cast<int>().Sum()}"); // Cast преобразует двумерный массив в одномерный
            Console.WriteLine($"AVG: {arr.Cast<int>().Average()}"); // Cast преобразует двумерный массив в одномерный
            Console.WriteLine($"Максимальное значение: {arr.Cast<int>().Max()}"); // Cast преобразует двумерный массив в одномерный
            Console.WriteLine($"Минимальное значение: {arr.Cast<int>().Min()}"); // Cast преобразует двумерный массив в одномерный

#endif

            int[][] arr = new int[][]
                {
                    new int[]{ 0, 1, 1, 2 },
                    new int[]{ 3, 5, 8 },
                    new int[]{ 13, 21},
                    new int[]{ 34, 55, 89}
                };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        } 
        }

    }