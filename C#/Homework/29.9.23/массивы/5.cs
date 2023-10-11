using System;
namespace sortcheck
{
    class Prog
    {
        static void Main()
        {
            var rand = new Random();
            int[] M = new int[5];
            string otpt = "";
            for (int i = 0; i < M.Length; i++)
            {
                //M[i] = rand.Next(1, 1000);
                M[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}: {M[i]}");
            }
            for (int i = 0; i < M.Length - 1; i++)
            {
                if ((M[i] > M[i + 1])&&(otpt != "ascending"))
                {
                    otpt = "descending";
                }
                else if ((M[i] < M[i + 1]) && (otpt != "descending"))
                {
                    otpt = "ascending";
                }
                else
                {
                    otpt = "unsorted";
                    break;
                }
            }
            Console.WriteLine(otpt);
        }
    }
}