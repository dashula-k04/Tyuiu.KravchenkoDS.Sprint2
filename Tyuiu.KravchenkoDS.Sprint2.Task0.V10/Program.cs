
using Tyuiu.KravchenkoDS.Sprint2.Task0.V10.Lib;
namespace Tyuiu.KravchenkoDS.Sprint2.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:  Операции сравнения                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("*последовательность операций не должна нарушаться)                        *");
            Console.WriteLine("*и арифметических выражений, которая вернет логическую последовательность *");
            Console.WriteLine("*(массив): False, True, False, True, False, True), при x = 1305, y = 475  *");


            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            { Console.WriteLine(res[i]); }
            Console.ReadKey();



        }
    }
}
