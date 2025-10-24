using Tyuiu.ChirchenkoME.Sprint3.Task1.V23.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task1.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет             *");
            Console.WriteLine("* произведение ряда по формуле:                                           *");
            Console.WriteLine("*       5   (   300   )^k                                                 *");
            Console.WriteLine("* p =   Π   ( ------- )                                                   *");
            Console.WriteLine("*      k=1   ( sin(x)+x^k )                                               *");
            Console.WriteLine("* при x = 5                                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine("x = " + value);
            Console.WriteLine("Start = " + startValue);
            Console.WriteLine("Stop = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Произведение ряда p = " + result);

            Console.ReadKey();
        }
    }
}