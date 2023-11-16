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
            Console.WriteLine(5.2d.GetType());
        }
    }
}
