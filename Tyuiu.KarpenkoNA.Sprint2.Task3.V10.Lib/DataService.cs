using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KarpenkoNA.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x - Math.Pow(((x + 15) / (x - 4)), x);
            }
            else
            {
                if (x == 0)
                {
                    y = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 2);
                }
                else
                {
                    if ((x < 0) && (x > -14))
                    {
                        y = Math.Pow((5 + ((1) / (Math.Pow(x, 2)))), x);
                    }
                    else
                    {
                        if (x < -14)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
