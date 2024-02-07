namespace BubbleSort
{
    class Prog
    {
        public static void Main()
		{
        int[] nums = {57, 12, 4, 321 , 61, 231};
        sort:
        for (int i = 0; i < (nums.Length - 1); i++)
        {
            if (nums[i] > nums[i+1])
            {
                nums[i] += nums[i+1];
                nums[i+1] = nums[i] - nums[i+1];
                nums[i] -= nums[i+1];
            }
        }
        
        for (int i = 0; i < (nums.Length - 1); i++)
            if (nums[i] > nums[i+1])
                goto sort;
        
        for (int i = 0; i < (nums.Length); i++)
            Console.Write($"{nums[i]} ");
		}
    }
}