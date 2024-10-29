using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RyabtsevNE.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            foreach (char chr in value)
            {
                if (Char.IsDigit(chr))
                {
                    value = value.Replace(chr, item);
                }
            }
            return value;
        }
    }
}
