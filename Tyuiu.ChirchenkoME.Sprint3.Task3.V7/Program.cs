using Tyuiu.ChirchenkoME.Sprint3.Task3.V7.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Чирченко М. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Чирченко М. Е. | ИСПб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, заменить буквы 'g' на цифру '4'                 *");
            Console.WriteLine("* в строке: \"gft hggf ntg\"                                              *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string input = "gft hggf ntg";
            char replaceable = 'g';
            char replacement = '4';

            Console.WriteLine("Строка: " + input);
            Console.WriteLine("Заменить символ: " + replaceable);
            Console.WriteLine("На символ: " + replacement);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.ReplaceCharOnNum(input, replaceable, replacement);

            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}