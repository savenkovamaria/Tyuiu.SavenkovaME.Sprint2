﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavenkovaME.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) && (((y + x) > 0) && 
                ((y - x)) > 0) && (y > 0 && y <=1) && (Math.Abs(x) <= 1 && x != 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
