using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = Math.Cos(x) + x;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (2.0 * x - 3.0) / denominator + 5.0;
                }

                result[index] = Math.Round(fx, 2);
                index++;
            }

            return result;
        }
    }
}