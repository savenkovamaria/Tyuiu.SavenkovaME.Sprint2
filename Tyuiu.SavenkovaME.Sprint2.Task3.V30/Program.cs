using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint2.Task3.V30.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.Task3.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                          *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #30                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y           *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит         *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                          *");
            Console.WriteLine("*          --                                                                  *");
            Console.WriteLine("*         |        (x + 1) ^ x , если x > 0                                    *");
            Console.WriteLine("*         |    x * -------                                                     *");
            Console.WriteLine("*         |        (x - 1)                                                     *");
            Console.WriteLine("*         |                                                                    *");
            Console.WriteLine("*         |  x ^ 2 - cos(x ^ 2) - 3                                            *");
            Console.WriteLine("*   y =  <|  ---------------------- , если x == 0                              *");
            Console.WriteLine("*         |  x ^ 2 - sin(x ^ 2) - 2                                            *");
            Console.WriteLine("*         |                                                                    *");
            Console.WriteLine("*         |  (1 + 1 / x ^ 2) ^ x , если -34 < x < 0                            *");
            Console.WriteLine("*         |                                                                    *");
            Console.WriteLine("*         |  x + 10 * x - (1 / x) , если x < -34                               *");
            Console.WriteLine("*          --                                                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Введите значение переменной X:");

            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            double result = ds.Calculate(x);
            Console.WriteLine($"При x = {x} значение функции Y = " + result);
            Console.ReadKey();
        }
    }
}
