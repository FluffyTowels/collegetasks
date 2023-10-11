using System;
namespace LabPrime
{
    class Prog
    {
        static void Main()
        {
            int N = Convert.ToInt32 (Console.ReadLine());
            bool isPrime;
                                                                //Console.WriteLine ("test" + N);
            for (int num = 2; num <= N; num++)
            {
                isPrime = true;
                for (int div = 2; (div <= num / 2); div++)
                {
                    if (num % div == 0) 
                    { 
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}