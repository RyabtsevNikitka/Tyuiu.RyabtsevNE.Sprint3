using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RyabtsevNE.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            double t = Convert.ToDouble(startValue);
            double k = Convert.ToDouble(stopValue);
            do
            {
                res = Math.Sin(k) * Math.Pow(0.5, k);
                k++;
            } while (k <= stopValue);
            return res;

        }
    }
}
