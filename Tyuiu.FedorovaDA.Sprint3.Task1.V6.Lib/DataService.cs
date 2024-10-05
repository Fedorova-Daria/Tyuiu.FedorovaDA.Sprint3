using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FedorovaDA.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int a = 4;
            
            startValue = 1;
            stopValue = 10;
            double res = 0;
            while (startValue <= stopValue)
            {
                res += (Math.Pow(a, startValue) + 1) * Math.Sin(startValue);
                startValue++;
            }
            
            return Math.Round(res, 3) ;
        }
    }
}
