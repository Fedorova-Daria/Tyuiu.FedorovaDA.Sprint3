﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FedorovaDA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            startValue = 1;
            stopValue = 15;
            double res = 1;
            for (double i = startValue; i <= stopValue; i++)
            {
                res *= (1 / Math.Pow(Math.Cos(5) + 1, 2));
            }
            return res;
        }
    }
}
