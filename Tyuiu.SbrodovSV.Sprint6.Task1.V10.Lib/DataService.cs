using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SbrodovSV.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[Math.Abs(startValue) + Math.Abs(stopValue) + 1];
            for (int i = startValue, x = 0; i <= stopValue; i++, x++)
            {
                if (3 * i + 0.5 != 0)
                {
                    result[x] = Math.Round(Math.Sin(i) + ((2) / (3 * i + 0.5)) - 2 * Math.Cos(i) * 2 * i, 2);
                }
                else
                {
                    result[x] = 0;
                }
            }
            return result;
        }
    }
}
