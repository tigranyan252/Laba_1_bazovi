using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_bazovi
{
    internal class Class77
    {
        public double A { get; set; }
        public double B { get; set; }
        public Class77(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Result()
        {
            return A * B;
        }
    }
}