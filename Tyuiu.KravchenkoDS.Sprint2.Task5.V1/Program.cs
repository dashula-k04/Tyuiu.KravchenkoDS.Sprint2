using Tyuiu.KravchenkoDS.Sprint2.Task5.V1.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Кравченко Д. С. | ИСТНБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: оператор  switch                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнила: Кравченко Дарья Сергеевна | ИСТНБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.*");
            Console.WriteLine("* По данному номеру месяца, определите количество дней в этом месяце..*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());
            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                int days = ds.FindMonthDaysCount(numMonth);
                res = "Количество дней в месяце: " + days;
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
        

