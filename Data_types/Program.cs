//#define CONSOLE_CHECK
//#define TASK_1
//#define TASK_2
//#define TASK_3
//#define TASK_4
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSOLE_CHECK
            Console.WriteLine($"bool: {sizeof(bool)}, values: {true} or {false}");
            Console.WriteLine($"bool: {sizeof(char)}");
            Console.WriteLine($"short: {sizeof(short)} Байт памяти  и принимает значение в диапазоне: {short.MinValue} .... {short.MaxValue}");
            Console.WriteLine($"short: {sizeof(ushort)} Байт памяти  и принимает значение в диапазоне: {ushort.MinValue} .... {ushort.MaxValue}");

            Console.WriteLine($"short: {sizeof(float)} Байт памяти  и принимает значение в диапазоне: {float.MinValue} .... {float.MaxValue}");
            Console.WriteLine($"short: {sizeof(double)} Байт памяти  и принимает значение в диапазоне: {double.MinValue} .... {double.MaxValue}");
            Console.WriteLine($"short: {sizeof(decimal)} Байт памяти  и принимает значение в диапазоне: {decimal.MinValue} .... {decimal.MaxValue}");


            Console.WriteLine('+'.GetType());
            Console.WriteLine(5.GetType());
            Console.WriteLine(5.2.GetType());
            Console.WriteLine(5.2f.GetType());
            Console.WriteLine(5.2m.GetType()); 
#endif

#if TASK_1
            Console.Write("Введите дробное число: ");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"{number} руб. = {Decimal.ToInt32(number)} руб. {Decimal.ToInt32(number*100)- Decimal.ToInt32(number)*100} коп.");
#endif //TASK_1
#if TASK_2
            Console.Write("Введите цену одной тетради: ");
            decimal price_notebook=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество купленных тетрадей: ");
            int count_notebook=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену одного карандаша: ");
            decimal price_pencil=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество купленных карандашей: ");
            int count_pencil=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(price_notebook*count_notebook)+(price_pencil*count_pencil)} руб.");
#endif //TASK_2
#if TASK_3
            Console.Write("Введите цену одной тетради: ");
            decimal price_notebook = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите цену одной обложки: ");
            decimal price_cover = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество комплектов: ");
            int count=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(price_cover+price_notebook)*count} руб.");
#endif //TASK_3
#if TASK_4
            Console.Write("Введите расстояние до дачи в км: ");
            double distance=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расход бензина на 100 км: ");
            double consumption=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену на 1 литр бензина в рублях: ");
            decimal price=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Поездка на дачу туда и обратно обойдется в {Decimal.Round(Convert.ToDecimal(distance/100*consumption)*price*2,2)} рублей");
#endif //TASK_4

            Random random = new Random();
            int[][] arr = new int[5][]; // Кол-во звеньев в зубчатом массиве. Выделяем место.
            arr[0] = new int[3]; // Нулевая ячейка содержит три ячейки
            arr[1] = new int[4]; // Первая ячейка содержит четыре ячейки
            arr[2] = new int[5]; // Вторая ячейка содержит пять ячеек
            arr[3] = new int[6]; // Третья ячейка содержит шесть ячеек
            arr[4] = new int[7]; // Четвертая ячейка содержит семь ячеек
            


            for (int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(1, 10); // Генерируем случайные числа от 1 до 10
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+ "\t"); //  Выводим
                }
                Console.WriteLine();
                
            }
            Console.WriteLine();

            
            for (int i = 0; i < arr.Length; i++)
            {
                double avg = arr[i].Average();
                int min = arr[i].Min();
                int max = arr[i].Max();
                int sum = arr[i].Sum();
                Console.WriteLine("ЗВЕНО:"+" "+ i);
                Console.WriteLine("Сумма в" +" "+ i + " звене зубчатого массива:" +"\t"+sum);
                Console.WriteLine( "Минимальное значение в звене:"+" " +"\t" + min);
                Console.WriteLine( "Максимальное значение в звене:"+" "+"\t" + max);
                Console.WriteLine("Среднее значение: " + " " + "\t" + + avg);
                Console.WriteLine();

            }
            Console.WriteLine();
             int sum_arr = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        sum_arr+= arr[i][j];
                    }
                }
            Console.WriteLine("Сумма чисел в зубчатом массиве:" + " " + sum_arr);
            //Console.WriteLine(arr[0].Length);
            //Console.WriteLine(arr.Length);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(string.Join(" \t", arr[i]));  // Метод вывода массива
                
                
            }
            //Console.WriteLine(sum.Average());
            int number_counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                number_counter += arr[i].Length;
            }
                Console.WriteLine("Колл-во элеметов в зубчатом массиве:"+" "+" "+number_counter);
            Console.WriteLine(sum_arr/number_counter);






            //Console.WriteLine("Длина первой цепи: " + arr[0].Length);
            //Console.WriteLine("Длина второй цепи: " + arr[1].Length);
            //Console.WriteLine("Длина третьей цепи: " + arr[2].Length);
            //Console.WriteLine("Длина четвертой цепи: " + arr[3].Length);
            //Console.WriteLine("Длина пятой цепи: " + arr[4].Length);



        }
    }
}
        
    

