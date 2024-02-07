namespace simplesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Длина массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = random.Next(10, 100);
            int[] sortNums = new int[n];
            for(int i = 0; i < n; i++) sortNums[i] = nums[i];

            int minNum = 101;
            int minAddr = 0;
            for (int i = 0; i < n; i++)
            {
                minNum = 101;
                for (int j = i; j < n; j++)
                {
                    if (sortNums[j] < minNum)
                    {
                        minNum = sortNums[j];
                        minAddr = j;
                    }
                }
                sortNums[i] = minNum + sortNums[i];
                sortNums[minAddr] = sortNums[i] - minNum;
                sortNums[i] = minNum;
            }
            for (int i = 0; i < n; i++) Console.WriteLine($"{nums[i]}  {sortNums[i]}");
        }
    }
}