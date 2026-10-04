using Tyuiu.KravchenkoDS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.KravchenkoDS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfDayNextDay_ValidDates()
        {
            DataService ds = new DataService();

            
            string res1 = ds.FindDateOfNextDay(2026, 5, 15);
            Assert.AreEqual("16.05.2026", res1);

            
            string res2 = ds.FindDateOfNextDay(2026, 5, 31);
            Assert.AreEqual("01.06.2026", res2);

           
            string res3 = ds.FindDateOfNextDay(2026, 12, 31);
            Assert.AreEqual("01.01.2027", res3);

            
            string res4 = ds.FindDateOfNextDay(2024, 2, 28);
            Assert.AreEqual("29.02.2024", res4);

            
            string res5 = ds.FindDateOfNextDay(2026, 2, 28);
            Assert.AreEqual("01.03.2026", res5);
        }
    }
}



        
    

