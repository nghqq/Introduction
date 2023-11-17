//#define TASK_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
        
    

