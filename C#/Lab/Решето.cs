using System;
namespace Eratosphenes
{
    class Prog
    {
        static void Main()
        {
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[N - 1];
            for (int i = 2; i <= N; i++)
            {
                nums[i - 2] = i;

            }
            for (int div = 0; div < nums.Length; div++)
            {
                if (nums[div] != 0)
                {
                    for (int num = (div + 1); num < nums.Length; num++)
                    {
                        if (nums[num] % nums[div] == 0)
                        {
                            nums[num] = 0;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Primes: ");
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    Console.Write($"{ nums[j]} ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}