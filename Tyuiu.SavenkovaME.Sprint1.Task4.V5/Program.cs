﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.Task4.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Class Math                                                          *");
            Console.WriteLine("* Задание #4                                                                *");
            Console.WriteLine("* Вариант #5                                                                *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные    *");
            Console.WriteLine("* и вычисляет 1/|x+sqrt(y)| печатает его на экране. *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            double x, y;
            Console.WriteLine("Введите первое число:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine($"Значение выржения 1/|{x}+sqrt({y})| = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
