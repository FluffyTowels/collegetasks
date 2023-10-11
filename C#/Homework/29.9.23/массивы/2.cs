using System;
namespace minmax
{
    class Prog
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write("length: ");
            int inptlngth = Convert.ToInt32(Console.ReadLine());
            double[] nums = new double[inptlngth];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.NextDouble() * (1000 - 1) + 1;
                Console.WriteLine($"{i + 1}: {nums[i]}");
            }
            double min = 1001;
            double max = 0;
            foreach (double i in nums)
            {
                if (i <= min)
                {
                    min = i;
                }
                else if (i >= max)
                {
                    max = i;
                }
            }
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("diff: " + (max - min));
        }
    }
}