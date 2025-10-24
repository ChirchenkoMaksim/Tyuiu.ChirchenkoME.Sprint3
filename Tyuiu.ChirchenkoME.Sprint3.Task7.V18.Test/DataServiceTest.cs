using Tyuiu.ChirchenkoME.Sprint3.Task7.V18.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.IsNotNull(result);
            Assert.AreEqual(11, result.Length); 
        }
    }
}