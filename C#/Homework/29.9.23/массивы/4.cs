using System;
namespace betweendouble
{
    class Prog
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write("length: ");
            int inptlngth = Convert.ToInt32(Console.ReadLine());
            double[] nums = new double[inptlngth];
            int cntr = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.NextDouble() * (1000 - -1000) + -1000;
                Console.WriteLine($"{i + 1}: {nums[i]}");
                if ((nums[i] > -100) && (nums[i] < 100))
                {
                    cntr++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cntr);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}