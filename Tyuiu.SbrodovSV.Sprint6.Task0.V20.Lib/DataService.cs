﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SbrodovSV.Sprint6.Task0.V20.Lib
{
    public class DataService : ISprint6Task0V20
    {
        public double Calculate(int x)
        {
            return Math.Round((3 * Math.Pow(x, 4) + 1) / Math.Pow(x, 3), 3);
        }
    }
}
