using System;

public class MainClass
{
    public static void Main()
    {
        string cardNumber = Console.ReadLine();


        // Ваш код       
        int min = 9;
        int max = 0;
        int[] nums = new int [cardNumber.Length];
        for (int i = 0; i < cardNumber.Length; i++)
        {
            nums[i] = Convert.ToInt32(Convert.ToString(cardNumber[i]));     //Можно так же nums[i] = Convert.ToInt32(cardNumber[i] - '0');
        }
        foreach (int i in nums)
        {
            if (i > max) max = i;
            if (i < min) min = i;
        }
        for (int i = (nums.Length - 1); i >= 0; i--) Console.Write(nums[i]);
        Console.WriteLine($"{max}{min}");
    }
}
