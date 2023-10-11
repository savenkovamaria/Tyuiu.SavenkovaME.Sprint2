using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavenkovaME.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {   

            switch (k % 7)
            {
                case 1 when d == 1: return "Понедельник";
                case 2 when d == 1: return "Вторник";
                case 3 when d == 1: return "Среда";
                case 4 when d == 1: return "Четверг";
                case 5 when d == 1: return "Пятница";
                case 6 when d == 1: return "Суббота";
                case 0 when d == 1: return "Воскресенье";

                case 0 when d == 2: return "Понедельник";
                case 1 when d == 2: return "Вторник";
                case 2 when d == 2: return "Среда";
                case 3 when d == 2: return "Четверг";
                case 4 when d == 2: return "Пятница";
                case 5 when d == 2: return "Суббота";
                case 6 when d == 2: return "Воскресенье";

                case 6 when d == 3: return "Понедельник";
                case 0 when d == 3: return "Вторник";
                case 1 when d == 3: return "Среда";
                case 2 when d == 3: return "Четверг";
                case 3 when d == 3: return "Пятница";
                case 4 when d == 3: return "Суббота";
                case 5 when d == 3: return "Воскресенье";

                case 5 when d == 4: return "Понедельник";
                case 6 when d == 4: return "Вторник";
                case 0 when d == 4: return "Среда";
                case 1 when d == 4: return "Четверг";
                case 2 when d == 4: return "Пятница";
                case 3 when d == 4: return "Суббота";
                case 4 when d == 4: return "Воскресенье";

                case 4 when d == 5: return "Понедельник";
                case 5 when d == 5: return "Вторник";
                case 6 when d == 5: return "Среда";
                case 0 when d == 5: return "Четверг";
                case 1 when d == 5: return "Пятница";
                case 2 when d == 5: return "Суббота";
                case 3 when d == 5: return "Воскресенье";

                case 3 when d == 6: return "Понедельник";
                case 4 when d == 6: return "Вторник";
                case 5 when d == 6: return "Среда";
                case 6 when d == 6: return "Четверг";
                case 0 when d == 6: return "Пятница";
                case 1 when d == 6: return "Суббота";
                case 2 when d == 6: return "Воскресенье";

                case 2 when d == 7: return "Понедельник";
                case 3 when d == 7: return "Вторник";
                case 4 when d == 7: return "Среда";
                case 5 when d == 7: return "Четверг";
                case 6 when d == 7: return "Пятница";
                case 0 when d == 7: return "Суббота";
                case 1 when d == 7: return "Воскресенье";

                default: throw new ArgumentException($"neverno, {k}");
            }
        }
    }
}
