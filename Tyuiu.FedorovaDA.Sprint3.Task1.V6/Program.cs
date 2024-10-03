using Tyuiu.FedorovaDA.Sprint3.Task1.V6.Lib;

namespace Tyuiu.FedorovaDA.Sprint3.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while,                                *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при a=4.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 1;
            int stopValue = 10;
            double res = 1;
            int a = 4;

            Console.WriteLine("Значение К =" + startValue);
            Console.WriteLine("Количество периода = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetSumSeries(a, startValue, stopValue);
            Console.WriteLine("Значение выражения = " + res);

        }
    }
}
