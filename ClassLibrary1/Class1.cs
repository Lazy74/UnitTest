using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private double a;
        private double b;
        private double c;
        private double D;
        public Class1()
        {
            a = 0;
            b = 0;
            c = 0;
            D = 0;
        }

        public Class1(double na, double nb, double nc)
        {
            a = na;
            b = nb;
            c = nc;
        }

        public double fn()
        {
            D = b * b - 4 * a * c;
            return D;
        }
    }
}
