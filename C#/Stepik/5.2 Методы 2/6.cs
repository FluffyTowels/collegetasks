static void ToEven(ref int[] arr)
{
    int evenCnt = 0;
    foreach (int i in arr) if (i % 2 == 0) evenCnt++;
    int[] otpt = new int[evenCnt];
    int arrPoint = 0;
    foreach (int i in arr) if (i % 2 == 0) 
    {
        otpt[arrPoint] = i;
        arrPoint++;
    }
    arr = otpt;
}