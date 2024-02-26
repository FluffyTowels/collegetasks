using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02
{
    public class Class4 : Class2
    {
        public char c { get; set; }
        public override string funcH(int g)
        {
            return $"{g} + {g} + {g}";
        }
        public override double funcM(int n)
        {
            return Convert.ToDouble(n + n);
        }
    }
}
