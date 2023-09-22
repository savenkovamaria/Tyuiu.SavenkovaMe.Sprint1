using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.Task3.V13.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                   *");
            Console.WriteLine("* Задание #3                                                                *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные    *");
            Console.WriteLine("* и вычисляет произведение цифр трехзначного числа, печатает его на экране. *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Введите любое трехзначное число: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine($"Произведение цифр числа {num3} = " + ds.MultiplyOfDigits(num3));
            Console.ReadKey();
        }
    }
}
