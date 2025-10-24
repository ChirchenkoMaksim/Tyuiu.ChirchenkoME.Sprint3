using Tyuiu.ChirchenkoME.Sprint3.Task6.V1.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [11, 17], сумму всех делителей.         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 11;
            int stopValue = 17;

            Console.WriteLine("Отрезок: [" + startValue + ", " + stopValue + "]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int totalDivisorsSum = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Сумма всех делителей = " + totalDivisorsSum);

            Console.ReadKey();
        }
    }
}