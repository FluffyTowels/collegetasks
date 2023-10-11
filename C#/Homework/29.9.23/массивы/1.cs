using System;
namespace ArrSort
{
    class Prog
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write("length: ");
            int inptlngth = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[inptlngth];
            int evencnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 1000);
                Console.WriteLine($"{i + 1}: {nums[i]}");
                if (nums[i] % 2 == 0) 
                {
                    evencnt++;
                }
            }
            int[] evennums = new int[evencnt];
            int[] oddnums = new int[inptlngth - evencnt];
            int evencntr = 0;
            int oddcntr = 0;
            for (int i = 0; i < inptlngth; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evennums[evencntr] = nums[i];
                    evencntr++;
                }
                else
                {
                    oddnums[oddcntr] = nums[i];
                    oddcntr++;
                }
            }

            Array.Sort(evennums);
            Array.Sort(oddnums);
            Console.WriteLine("Even:");
            for (int i = 0; i < evennums.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + evennums[i]);
            }
            Console.WriteLine("Odd:");
            for (int i = 0; i < oddnums.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + oddnums[i]);
            }
        }
    }
}