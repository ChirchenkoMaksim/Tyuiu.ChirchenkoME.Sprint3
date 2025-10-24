using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int divisorSum = 0;
                for (int d = 1; d <= n; d++)
                {
                    if (n % d == 0)
                        divisorSum += d;
                }
                totalSum += divisorSum;
            }

            return totalSum;
        }
    }
}