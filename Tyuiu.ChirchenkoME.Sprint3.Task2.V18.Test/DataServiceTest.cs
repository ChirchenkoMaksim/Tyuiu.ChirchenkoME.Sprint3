using Tyuiu.ChirchenkoME.Sprint3.Task2.V18.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.000; // ← Подставь реальное значение после расчёта

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}