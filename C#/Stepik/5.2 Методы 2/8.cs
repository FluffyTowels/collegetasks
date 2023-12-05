static void Delta (int[] arr) 
{
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) arrCopy[i] = arr[i];
    for (int i = 1; i < arr.Length; i++) arr[i] = arrCopy[i] - arrCopy[i-1];
    foreach (int i in arr) Console.Write(i + " ");
}