using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.Task7.V11.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                       *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                         *");
            Console.WriteLine("* Задание #7                                                                      *");
            Console.WriteLine("* Вариант #11                                                                     *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                           *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные          *");
            Console.WriteLine("*                  (ln(sin(x)))^x                                                 *");
            Console.WriteLine("* и вычисляет   z= --------------  + (y-sqrt(|x|) и печатает результат на экране. *");
            Console.WriteLine("*                   (ln(1+x^2))                                                   *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Введите число Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число У:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Значение выражения = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
