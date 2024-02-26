using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _26._02
{
    public class Class3 : Class1
    {
        public double pi = System.Math.PI;
        public override double funcM(int n)
        {
            return Convert.ToDouble(n * n * n);
        }
    }
}
