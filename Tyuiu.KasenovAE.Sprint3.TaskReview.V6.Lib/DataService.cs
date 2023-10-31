using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KasenovAE.Sprint3.TaskReview.V6.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((4 * x - 0.5) == 0)
                    res[count] = 0;
                else
                    res[count] = Math.Round((3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);
                count++;
            }

            return res;
        }
    }
}
