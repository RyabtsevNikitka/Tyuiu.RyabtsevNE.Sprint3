using Tyuiu.RyabtsevNE.Sprint3.Task3.V18.Lib;

namespace Tyuiu.RyabtsevNE.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "4n5nvf 56 bgy";
            char item = 'n';
            var res = ds.ReplaceNumOnChar(value, item);
            string wait = "nnnnvf nn bgy";
            Assert.AreEqual(wait, res);
        }
    }
}