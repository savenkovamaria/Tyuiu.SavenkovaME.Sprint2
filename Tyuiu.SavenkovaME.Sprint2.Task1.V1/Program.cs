using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.SavenkovaME.Sprint2.Task1.V1.Lib;

namespace Tyuiu.SavenkovaME.Sprint2.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2| Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                    *");
            Console.WriteLine("* Тема: Логические операции                                                    *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=) и            *");
            Console.WriteLine("* логических операций (|, &, ||, &&, !, ^), а также арифметических выражений,  *");
            Console.WriteLine("* которая вернет логическую последовательность:                                *");
            Console.WriteLine("* (True, False, True, False, True, False), a = 119, b = 196, c = 134, d = 327  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;
            bool[] result = new bool[6];
            Console.WriteLine($"* A = {a}                                                                      *");
            Console.WriteLine($"* B = {b}                                                                      *");
            Console.WriteLine($"* C = {c}                                                                      *");
            Console.WriteLine($"* D = {d}                                                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            result = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}
