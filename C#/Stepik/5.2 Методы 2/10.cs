static void AhShitHereWeGoAgain(int[] arr, int hhAmm)
{
    int[] otpt = new int[arr.Length + 1];
    otpt[0] = 0;
    for (int i = 0; i < arr.Length; i++) otpt[i+1] = arr[i];
    DeltaDecoding(otpt);
    int min = MinArray(otpt);
    for (int i = 0; i < otpt.Length; i++)   otpt[i] = otpt[i] - min + hhAmm;
    foreach (int i in otpt) Console.Write(i + " ");
}

static void DeltaDecoding(int[] arr)
{
    for (int i = 1; i < arr.Length; i++) arr[i] += arr[i - 1];
}

static int MinArray(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++) if (min > arr[i])  min = arr[i];
    return min;
}
