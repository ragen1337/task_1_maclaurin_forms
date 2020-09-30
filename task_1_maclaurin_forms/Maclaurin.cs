using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_maclaurin_forms
{
    class Maclaurin
    {
        public double Maclaurin1(double X, int N, ref double LastElem)
        {
            double Previous = 1, Sum = 1, Elem = 1;

            double PoweredX = Math.Pow(X, 2);
            for (int i = 0; i < N; i++)
            {
                Elem = (Previous * (-1) * PoweredX) / ((2 * i + 2) * (2 * i + 3));

                Sum += Elem;
                Previous = Elem;
            }

            LastElem = Elem;
            return Sum;
        }

        public double Maclaurin2(double x, double e, ref int n)
        {
            double Previous = 1, Sum = 1, Elem = 1;

            double PoweredX = Math.Pow(x, 2);
            int i = 0;
            while (true)
            {
                Elem = (Previous * (-1) * PoweredX) / ((2 * i + 2) * (2 * i + 3));
                if (Math.Abs(Elem) > e)
                {
                    Sum += Elem;
                    Previous = Elem;
                    i++;
                }
                else
                {
                    n = i;
                    return Sum;
                }
            }
        }
    }
}
