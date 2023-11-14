﻿//#define CLASS_CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASS_CONSOLE
            Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\t\t\t\t\tПривет .NET ");
            Console.CursorLeft = 32;
            Console.CursorTop = 8;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Cursor Position");
            Console.ResetColor();

            Console.Beep(500, 2000); 
#endif
            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(last_name+ " " +first_name+" "+age+" y/o "); // конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2} y/o", last_name, first_name, age)); //Форматирование строк
            Console.WriteLine($"{last_name} {first_name} {age} y/o");  //интерполяция строк
        }
    }
}
