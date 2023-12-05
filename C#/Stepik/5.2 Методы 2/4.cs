static int[] ArraySum(int[] A, int[] B)
{
    int greatLeng = 0;
    int lessLeng = 0;
    bool isA = false;
    if (A.Length > B.Length) 
    {
        greatLeng = A.Length;
        lessLeng = B.Length;
        isA = true;
    }
    else 
    {
        greatLeng = B.Length;
        lessLeng = A.Length;
    }
    int[] sum = new int[greatLeng];
    for (int i = 0; i < sum.Length; i++)
    {
        if (i < lessLeng) sum[i] = A[i] + B[i];
        else if (isA) sum[i] = A[i];
        else sum[i] = B[i];
    }
    return sum;
}
