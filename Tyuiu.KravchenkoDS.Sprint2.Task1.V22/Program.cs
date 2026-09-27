using Tyuiu.KravchenkoDS.Sprint2.Task1.V22.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность*");
            Console.WriteLine("*  можно чередовать, но использовать один раз в выражении) и                     *");
            Console.WriteLine("*логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность *");
            Console.WriteLine("*(массив): (True, True, True, False, False, False), при a = 324, b = 696, c = 254, d = 155*");


            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" a =" + a);
            Console.WriteLine(" b =" + b);
            Console.WriteLine(" c =" + c);
            Console.WriteLine(" d =" + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            { Console.WriteLine(res[i]); }
            Console.ReadKey();


        }
    }
}
