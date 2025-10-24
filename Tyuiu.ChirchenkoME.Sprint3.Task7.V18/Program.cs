using Tyuiu.ChirchenkoME.Sprint3.Task7.V18.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+-----+--------+");
            Console.WriteLine("|  x  |  f(x)  |");
            Console.WriteLine("+-----+--------+");

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"| {x,3} | {valueArray[i],6:F2} |");
            }

            Console.WriteLine("+-----+--------+");

            Console.ReadKey();
        }
    }
}