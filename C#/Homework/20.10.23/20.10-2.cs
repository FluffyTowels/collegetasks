using System;
namespace LoopsnIfs
{
    class Prog
    {
        static void Main()
        {
            int[] A = CreateRandArray(30);
            Console.WriteLine(ThirtyNum(A));
            Console.WriteLine(Street(A));
        }
        static int ThirtyNum(int[] A)               // Даны 30 чисел, образующих неубывающую последовательность.
        {                                           // Найти количество различных чисел в последовательности.
            int cntr = 1;
            Array.Sort(A);
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i-1])
                {
                    cntr++;
                }
            }
            return cntr;
        }
        static string Street(int[] houses)           // Известно число жителей, проживающих в каждом доме улицы.
        {                                            // Нумерация домов проведена подряд. 
            int OddSum = 0;                          // Дома с нечетными номерами расположены на одной стороне улицы, с четными — на другой. 
            int EvenSum = 0;                         // На какой стороне улицы проживает больше жителей? Использовать только один оператор цикла.
            for (int i = 0; i < houses.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    EvenSum += houses[i];
                }         
                else
                {
                    OddSum += houses[i];
                }
            }
            if (EvenSum > OddSum)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        static int Average (int a)                    // Даны натуральное число m и целые числа a1, a2, …, am.  
        {                                             // Определить среднее арифметическое тех чисел ai , которые кратны числу n. 
            return a;                                 // Допустить, что чисел, кратных n, среди заданных может не быть.          
            // Не понял задание
        }

        static int[] CreateRandArray(int N)
        {
            var rand = new Random();
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = rand.Next(1, 1000);
            }
            return A;
        }
    }
}