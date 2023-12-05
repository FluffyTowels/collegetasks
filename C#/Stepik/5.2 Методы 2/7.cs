static void ArraySort(int[] arr, out int[] sort, out int[] sortRev)
{
    sort = new int[arr.Length];
    sortRev = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        sort[i] = arr[i];
        sortRev[i] = arr[i];
    }
    Array.Sort(sort);
    Array.Sort(sortRev);
    Array.Reverse(sortRev);
}