using System;
namespace between
{
    class Prog
    {
        static void Main()
        {
            var rand = new Random();
            int[] M = new int[100];
            int cntr = 0;
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rand.Next(-1000, 1000);
                Console.WriteLine($"{i + 1}: {M[i]}");
                if ((M[i] > 0) && (M[i] < 125))
                {
                    cntr++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cntr);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}