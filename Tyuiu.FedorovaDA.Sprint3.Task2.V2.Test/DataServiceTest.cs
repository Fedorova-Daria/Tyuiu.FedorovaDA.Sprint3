using Tyuiu.FedorovaDA.Sprint3.Task2.V2.Lib;
namespace Tyuiu.FedorovaDA.Sprint3.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries(k, stopValue);
            Assert.AreEqual(6482.439, res);

        }
    }
}