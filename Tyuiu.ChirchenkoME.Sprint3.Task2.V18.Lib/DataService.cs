using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double x = value;
            double product = 1.0;
            int k = startValue;

            do
            {
                double term = Math.Cos(x) + Math.Pow(k / 8.0, 3);
                product *= term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}