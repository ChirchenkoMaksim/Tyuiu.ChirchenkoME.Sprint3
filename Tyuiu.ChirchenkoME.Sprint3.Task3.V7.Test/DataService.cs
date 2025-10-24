using Tyuiu.ChirchenkoME.Sprint3.Task3.V7.Lib;
namespace Tyuiu.ChirchenkoME.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string input = "gft hggf ntg";
            char replaceable = 'g';
            char replacement = '4';

            string result = ds.ReplaceCharOnNum(input, replaceable, replacement);
            string expected = "4ft h44f nt4";

            Assert.AreEqual(expected, result);
        }
    }
}