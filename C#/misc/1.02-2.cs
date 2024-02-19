namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Длина массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++ ) nums[i] = random.Next(100);
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(i);
                Console.ResetColor();
            }
            
            int oddsum = 0;
            foreach (int i in nums) if (i % 2 != 0) oddsum += i;
            Console.WriteLine($"Сумма нечётных чисел: {oddsum}");

            int maxNum = 0;
            foreach(int i in nums) if (i > maxNum) maxNum = i;
            Console.WriteLine($"Наибольшее число: {maxNum}");
        }
    }
}