using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();


        // Ваш код       
        string[] split = line.Split(" ");
        int[] nums = new int[split.Length];
        for (int i = 0; i < split.Length; i++)
            nums[i] = int.Parse(split[i]);
        
		sort:
        for (int i = 0; i < (nums.Length - 1); i++)
        {
            if (nums[i] > nums[i+1])
            {
                nums[i] += nums[i+1];						//меняем числа местами
                nums[i+1] = nums[i] - nums[i+1];			//меняем числа местами
                nums[i] -= nums[i+1];						//меняем числа местами
            }
        }
        
        for (int i = 0; i < (nums.Length - 1); i++)			
            if (nums[i] > nums[i+1])						//проверяем сортировку
                goto sort;									//возращаемся к сортировке если не отсортировано
        
        for (int i = 0; i < (nums.Length); i++)
            Console.Write($"{nums[i]} ");
    }
}