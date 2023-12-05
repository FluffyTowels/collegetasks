static double GeometricMean(params int[] inpt) 
{
    double otpt = 1;
    foreach (int i in inpt) otpt *= i;
    otpt = System.Math.Pow(otpt, 1.0/inpt.Length);
    return otpt;
}