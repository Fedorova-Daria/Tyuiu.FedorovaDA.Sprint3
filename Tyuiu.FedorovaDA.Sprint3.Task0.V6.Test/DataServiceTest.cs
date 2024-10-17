using Tyuiu.FedorovaDA.Sprint3.Task0.V6.Lib;
namespace Tyuiu.FedorovaDA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            Assert.AreEqual(0.001, res);
        }
    }
}