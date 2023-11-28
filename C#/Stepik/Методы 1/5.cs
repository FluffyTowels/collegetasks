//Ваш код
static List<int> GetMultiple(int start, int end) 
{
    List<int> nums = new List<int>();
    for (int i = start; i <= end; i++)
        if (i % 7 == 0 && i != 0)
            nums.Add(i);
    return nums;
}

static void PrintEven(List<int> nums) 
{
    for (int i = 1; i < nums.Count; i += 2)
    {
        Console.Write(nums[i] + " ");
    }
}



