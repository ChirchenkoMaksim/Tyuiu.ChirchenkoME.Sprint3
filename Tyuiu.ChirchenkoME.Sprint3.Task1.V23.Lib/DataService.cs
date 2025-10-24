using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double x = value;
            double product = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double denominator = Math.Sin(x) + Math.Pow(x, k);
                double term = Math.Pow(300.0 / denominator, k);
                product *= term;

                k++;
            }

            return Math.Round(product, 3);
        }
    }
}