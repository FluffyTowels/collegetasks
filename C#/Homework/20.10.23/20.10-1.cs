using System;
namespace doubleloop
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine(MaxDivInterval(1, 100));
            RectList(60, true);
            Console.WriteLine(NatRow(2, 5));
        }

        static int MaxDivInterval(int a, int b)         //Найти натуральное число из интервала от a до b с максимальной суммой делителей.
        {
            int maxdivsum = 0;
            int otpt = 0;                                   
            int divsum = 0;
            for (int i = a; i <= b; i++)
            {
                divsum = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        divsum += j;
                    }
                    if (divsum > maxdivsum)
                    {
                        maxdivsum = divsum;
                        otpt = i;
                    }
                }
            }
            return otpt;
        }
        static void RectList (int S, bool a)                        // Найти размеры всех прямоугольников,
        {                                                           // площадь которых равна заданному натуральному числу s и стороны которых выражены натуральными числами.
            if (a)                                                  // При этом решения, которые получаются перестановкой размеров сторон:
            {                                                       // а) считать разными;
                for (int i = 1; i <= S; i++)                        // б) считать совпадающими. 
                {
                    if (S % i == 0)
                    {
                        Console.WriteLine($"a = {i}; b = {S / i}");
                    }
                }
            }
            else                                                    //б
            {
                int bmin = 10000;
                for (int i = 1; i < bmin; i++)
                {
                    if (S / i < bmin)
                    {
                        bmin = S / i;
                    }
                    if (S % i == 0)
                    {
                        Console.WriteLine($"a = {i}; b = {S / i}");
                    }
                }
            }
        }
        static int NatRow (int n, int m)                            //Даны натуральные числа m и n. Вычислить 1n + 2n + … + mn.
        {
            int otpt = 0;
            for (int i = 1; i <= m; i++)
            {
                otpt += i * n;
            }
            return otpt;
        }
    }
}