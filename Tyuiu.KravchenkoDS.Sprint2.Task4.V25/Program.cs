using Tyuiu.KravchenkoDS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task4.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать пррограмму, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора,где пользователь вводит значение переменной X,У с клавиатуры.*");
            Console.WriteLine("*Округлить полученное значение до трех знаков после запятой               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();

        }
    }
}
