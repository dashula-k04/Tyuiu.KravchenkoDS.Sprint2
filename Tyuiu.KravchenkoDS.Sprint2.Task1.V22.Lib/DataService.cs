
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KravchenkoDS.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res [0] =(a < b)  | (d < c);
            res [1] =(a + 4 <  b) & (d < c);
            res[2] = (a > b) || (d < c);
            res[3] = (a < b) && (d > c);
            res[4] = !(res[0]);
            res[5] = (a < b) ^ (d < c);
            return res;
        }
    }
}
