using Tyuiu.FedorovaDA.Sprint3.Task0.V6.Lib;

namespace Tyuiu.FedorovaDA.Sprint3.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;
            double res = 1;

            res = ds.GetMultiplySeries(startValue, stopValue);
            Console.WriteLine(res);

        }
    }
}
