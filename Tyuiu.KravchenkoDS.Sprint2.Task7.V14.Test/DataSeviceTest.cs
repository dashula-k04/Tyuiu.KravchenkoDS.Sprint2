using Tyuiu.KravchenkoDS.Sprint2.Task7.V14.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);


        }
    }
}
