using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Получение результата из switch                                         *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, использующую сокращенную форму записи оператора switch   *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат. Дано целое число        *");
            Console.WriteLine("* k (1 <= k <= 365). Определить, каким днем недели является k-й день           *");
            Console.WriteLine("* не високосного года, в котором 1 января d-й день недели                      *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите номер дня недели, с которого начинается 1 января:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число:");
            int value = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDayName(value, d);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            if (value >= 1 && value <= 365 && d >= 1 && d <= 7)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine($"Неправильное значение, {value}, {d}");
            }
            Console.ReadKey();
        }
    }
}
