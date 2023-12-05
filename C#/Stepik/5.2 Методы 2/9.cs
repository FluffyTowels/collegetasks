static void DeltaDecoding (int[] arr) 
{
    for (int i = 1; i < arr.Length; i++) arr[i] += arr[i-1];
    foreach (int i in arr) Console.Write(i + " ");
}