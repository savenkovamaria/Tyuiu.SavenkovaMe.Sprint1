using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.Task5.V4.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                *");
            Console.WriteLine("* Задание #5                                                                *");
            Console.WriteLine("* Вариант #4                                                                *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные    *");
            Console.WriteLine("* и вычисляет полное количество часов за К секунд.                          *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Введите количество секунд: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine($"{k} сек составляет - " + ds.SecondsToHours(k)+" ч");
            Console.ReadKey();
        }
    }
}
