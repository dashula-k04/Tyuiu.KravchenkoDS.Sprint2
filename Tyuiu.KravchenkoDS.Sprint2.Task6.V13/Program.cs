using Tyuiu.KravchenkoDS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из  switch                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая использует сокращенную форму записи оператора switch" +
                " вычисляет требуемое значение и возвращает результат. .*");
            Console.WriteLine("*Дата некоторого дня характеризуется тремя натуральными числами: g (год)," +
                " m (порядковый номер месяца) и n (число). По заданным g, n и m определить дату следующего дня. " +
                "Заданный год является високосным. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Дата следующего дня: {res}");

            Console.ReadKey();

        }
    }
}
