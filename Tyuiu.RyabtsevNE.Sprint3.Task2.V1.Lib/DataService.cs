using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RyabtsevNE.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            double t = Convert.ToDouble(startValue);
            double i = Convert.ToDouble(stopValue);
            do
            {
                res = Math.Sin(i) * Math.Pow(0.5, i);
                i++;
            } while (i <= stopValue);
            return res;

        }
    }
}
