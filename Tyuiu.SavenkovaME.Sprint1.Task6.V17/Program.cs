using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint1.Task6.V17.Lib;

namespace Tyuiu.SavenkovaME.Sprint1.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Работа со строками класс String                                     *");
            Console.WriteLine("* Задание #6                                                                *");
            Console.WriteLine("* Вариант #17                                                               *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                     *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя строку             *");
            Console.WriteLine("* и проверяет является ли данная строка перевертышем.                       *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Введите строку:");
            string slovo = Console.ReadLine();
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");
            if (ds.CheckPalindrome(slovo) == true)
            {
                Console.WriteLine($"Слово «{slovo}» - является перевертышем.");
            }
            else
            {
                Console.WriteLine($"Слово «{slovo}» - НЕ является перевертышем.");
            }
            Console.ReadKey();
        }
    }
}
