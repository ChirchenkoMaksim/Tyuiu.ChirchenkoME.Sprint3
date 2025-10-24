using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0.0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double term = Math.Pow(x, k) + Math.Cos(k);
                    sum += term;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}