using Tyuiu.FedorovaDA.Sprint3.Task0.V6.Lib;

namespace Tyuiu.FedorovaDA.Sprint3.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Федорова Дарья Артемовна | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for,                                  *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 1;
            int stopValue = 15;
            double res = 1;

            Console.WriteLine("Значение К =" + startValue);
            Console.WriteLine("Количество периода = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetMultiplySeries(startValue, stopValue);
            Console.WriteLine("Значение выражения = " + res);

        }
    }
}
