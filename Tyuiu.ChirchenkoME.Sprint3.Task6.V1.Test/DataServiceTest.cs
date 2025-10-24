using Tyuiu.ChirchenkoME.Sprint3.Task6.V1.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 11;
            int stopValue = 17;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int expected = 151; 

            Assert.AreEqual(expected, result);
        }
    }
}