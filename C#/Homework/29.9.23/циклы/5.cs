using System;
using static System.Math;
namespace Heigths
{
    class Prog
    {
        static void Main()
        {
            int[] hgts = new int[15]{180, 178, 176, 174, 172, 170, 168, 166, 164, 162, 160, 158, 156, 154, 152};
            int newhgt = Convert.ToInt32(Console.ReadLine());
            int[] newhgts = new int[hgts.Length + 1];
            int j = 0;
            bool cntr = true;
            for (int i = 0; i < 15; i++)
            {
                if (newhgt > hgts[i] && cntr)
                {
                    newhgts[i] = newhgt;
                    j++;
                    newhgts[j] = hgts[i];
                    j++;
                    cntr = false;
                }
                else
                {
                    newhgts[j] = hgts[i];
                    j++;
                }
                if (i == 14 && cntr)
                {
                    newhgts[15] = newhgt;
                }
            }
            for (int i = 0; i < newhgts.Length; i++)
            {
                Console.Write($"{i+1}: ");
                Console.WriteLine(newhgts[i]);
            }
        }
    }
}