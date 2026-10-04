using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KravchenkoDS.Sprint2.Task6.V13.Lib
{
    public class DataService :   ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => (g % 4 == 0 && g % 100 != 0 || g % 400 == 0) ? 29 : 28,
                _ => throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}")
            };      
            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m < 12)
                {
                    m++;
                }
                else
                {
                    m = 1;
                    g++;
                }
            }
            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}
