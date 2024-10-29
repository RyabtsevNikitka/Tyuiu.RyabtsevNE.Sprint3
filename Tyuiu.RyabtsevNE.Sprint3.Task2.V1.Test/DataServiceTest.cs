using Tyuiu.RyabtsevNE.Sprint3.Task2.V1.Lib;

namespace Tyuiu.RyabtsevNE.Sprint3.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1, stopValue = 10;
            var res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 7.5;

            Assert.AreEqual(wait, res);
        }
    }
}