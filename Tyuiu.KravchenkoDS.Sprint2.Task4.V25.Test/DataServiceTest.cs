using Tyuiu.KravchenkoDS.Sprint2.Task4.V25.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {  
            DataService ds = new DataService();
            double x = 5.0;
            double y = 4.0;
            double res = ds.Calculate(x, y);
            double wait = 1.360;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]

        public void ValidCondition2()
        {  DataService ds = new DataService();
            double x = 2.0;
            double y =  -152.0;
            double res = ds.Calculate(x, y);
            double wait = -152.0;
            Assert.AreEqual(wait, res);









        }







    }     
}
