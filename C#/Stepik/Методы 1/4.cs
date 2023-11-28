//Ваш код
static int[] GetCubes(int start, int end) 
{
    int[] cubes = new int[end - start + 1];
    for (int i = start; i <= end; i++)
    {
        cubes[i - start] = i*i*i;
    }
    return cubes;
}

static int PrintSum(int[] nums) 
{
    int sum = 0;
    foreach(int i in nums)
        sum += i;
    Console.WriteLine(sum);
    return sum;
}


