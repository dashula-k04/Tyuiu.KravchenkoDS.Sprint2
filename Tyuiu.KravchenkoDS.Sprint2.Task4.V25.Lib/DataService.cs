using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KravchenkoDS.Sprint2.Task4.V25.Lib
{
    public class DataService : ISprint2Task4V25
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 20 * 2.0 < y / 4.0) ? Math.Pow(1.0 + 2.0 / Math.Pow(x, 2.0), y) : y + Math.Pow((x + 1.0) / (y + 2.0), x);
            return Math.Round(z, 3);
        }
    }
}
