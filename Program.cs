using System;
using static System.Math;
namespace square
{
    class Prog
    {
        static void Main()
        {
            int a = 10;
            int b = 1;
            do
            {
                Console.WriteLine($"{a} {Sqrt(a)}");
                a--;
            }
            while (a >= b);
        }
    }
}