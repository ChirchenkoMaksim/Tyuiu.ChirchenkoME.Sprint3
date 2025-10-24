using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ChirchenkoME.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            List<char> output = new List<char>();

            foreach (char c in value)
            {
                if (c == replaceable)
                    output.Add(replacement);
                else
                    output.Add(c);
            }

            return new string(output.ToArray());
        }
    }
}