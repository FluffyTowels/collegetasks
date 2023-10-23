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
 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    for (int j = 2 * nums[i]; j - 2 <= nums.Length ; j += nums[i])
                    {
                        nums[j - 2] = 0;
                    }
                }
            }

            Console.Write("All: ");
            for (int j = 0; j < nums.Length; j++)
            {
                    Console.Write($"{nums[j]} ");
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Primes: ");
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    Console.Write($"{nums[j]} ");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
