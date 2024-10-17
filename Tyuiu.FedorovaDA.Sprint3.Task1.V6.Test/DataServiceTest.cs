using Tyuiu.FedorovaDA.Sprint3.Task1.V6.Lib;
namespace Tyuiu.FedorovaDA.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            int a = 4;
            double res = ds.GetSumSeries(a, startValue, stopValue);
            Assert.AreEqual(-389102.25, res);


        }
    }
}