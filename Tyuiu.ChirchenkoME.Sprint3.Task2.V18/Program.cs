using Tyuiu.ChirchenkoME.Sprint3.Task2.V18.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* произведение ряда по формуле:                                           *");
            Console.WriteLine("*       14                                                                *");
            Console.WriteLine("* p =   Π   ( cos(x) + (k/8)^3 )                                          *");
            Console.WriteLine("*      k=1                                                                *");
            Console.WriteLine("* при x = 1                                                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 14;

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