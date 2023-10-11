using System;
using static System.Math;
namespace TwentyStudents
{
    class Prog
    {
        static void Main()
        {
            int[] grds = new int[20];
            for (int i = 0; i < grds.Length; i++)
            {
                Console.Write($"{i+1}: ");
                grds[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            int cntr = 0;
            while (grds[j] == 5)
            {
                cntr++;
                j++;
            }
            Console.WriteLine($"5: {cntr}");
        }
    }
}