﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SavenkovaME.Sprint2.Task3.V30.Lib
{
    public class DataService : ISprint2Task3V30
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = x * Math.Pow(((x + 1) / (x - 1)), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) - 2);
                }
                else
                {
                    if ((x < 0) && (x > -34))
                    {
                        y = Math.Pow((1 + 1 / Math.Pow(x, 2)), x);
                    }
                    else
                    {
                        if (x < -34)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                     
                }
            }
            return Math.Round(y, 3);
        }
    }
}
