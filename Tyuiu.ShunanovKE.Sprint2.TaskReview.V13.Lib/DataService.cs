﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.TaskReview.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((x * x + y * y <= 1) && (x >= 0)) || ((y >= x - 1) && (y <= 1)) && (x >= 0)) return true;
            else return false;
        }
    }
}
