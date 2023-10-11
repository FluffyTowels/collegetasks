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
            do                                        //Цикл с постусловием
            {                                         //
                Console.WriteLine($"{a} {Sqrt(a)}");  //Вывод a и квадратного корня a. Комманла Sqrt из System.Math
                a--;                                  //a = a - 1
            }                                         //
            while (a >= b);                           //Условие цикла. Цикл выполняется пока a больше или равно b
        }
    }
}
