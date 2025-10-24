using Tyuiu.ChirchenkoME.Sprint3.Task0.V25.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет               *");
            Console.WriteLine("* сумму ряда по формуле:                                                  *");
            Console.WriteLine("*       14   (   4   )^i                                                  *");
            Console.WriteLine("* S =   Σ   ( ----- )                                                     *");
            Console.WriteLine("*      i=1   ( 1+x^i )                                                    *");
            Console.WriteLine("* при x = 5                                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("x = " + value);
            Console.WriteLine("Start = " + startValue);
            Console.WriteLine("Stop = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("Сумма ряда S = " + result);

            Console.ReadKey();
        }
    }
}