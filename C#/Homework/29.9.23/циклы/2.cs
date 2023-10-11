using System;
using static System.Math;
namespace NatNum
{
    class Prog
    {
        static void Main()
        {
            string inptstr = Console.ReadLine();
            int[] dgts = new int[inptstr.Length];
            int inpt = Convert.ToInt32(inptstr);
            for (int i = 0; i < inptstr.Length; i++)
            {
                dgts[i] = inpt % 10;
                inpt /= 10;
            }
            
            Console.WriteLine($"Количество цифр: {inptstr.Length}"); 
            
            int dgtsum = 0;
            for (int i = 0;i < inptstr.Length; i++)
            {
                dgtsum += dgts[i];
            }
            Console.WriteLine($"Сумма: {dgtsum}");
            
            int dgtmult = 1;
            for (int i = 0; i < inptstr.Length; i++)
            {
                dgtmult *= dgts[i];
            }
            Console.WriteLine($"Произведение: {dgtmult}");

            Console.WriteLine($"Среднее Арифметическое: {dgtsum / inptstr.Length}");
            
            int dgtsumsqr = 0;
            for (int i = 0; i < inptstr.Length; i++)
            {
                dgtsumsqr += dgts[i] * dgts[i];
            }
            Console.WriteLine($"Сумма квадратов: {dgtsumsqr}");
            
            int dgtsumcub = 0;
            for (int i = 0; i < inptstr.Length; i++)
            {
                dgtsumcub += dgts[i] * dgts[i] * dgts[i]; 
            }
            Console.WriteLine($"Сумма кубов: {dgtsumcub}");

            Console.WriteLine($"Первая цифра: {dgts[inptstr.Length - 1]}");

            Console.WriteLine($"Сумма Первой и последней цифр: {dgts[inptstr.Length - 1] + dgts[0]}");
        }
    }
}