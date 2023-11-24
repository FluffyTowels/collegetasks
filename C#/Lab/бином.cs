using System;
namespace doubleloop
{
    class Prog
    {
        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine()); 
            Console.Write($"\n");
            int[] a = BinomLine(n);
            Console.WriteLine("BinomLine: ");
            foreach (int i in a) { Console.Write($"{i} "); }
            Console.WriteLine($"\n");
            Console.WriteLine("BinomPrint: ");
            BinomPrint(n);
        }
        
        
        static int[] BinomLine(int number)
        {
            if (number < 0) { int[] a = { 1 }; return a; }
            int[] prevline = BinomLine(number - 1);
            int[] line = new int[number+1];
            if (number == 0)
            {
                line[0] = 1;
                return line;
            }
            else
            {
                line[0] = 1;
                line[number] = 1;
            }
            for (int i = 1; i < number; i++)
            {
                line[i] = prevline[i-1] + prevline[i];
            }
            return line;
        }
        
        
        static int[] BinomPrint(int number)
        {
            if (number < 0) { int[] a = { 1 }; return a; }
            int[] prevline = BinomPrint(number - 1);
            int[] line = new int[number + 1];
            if (number == 0)
            {
                line[0] = 1;
                Console.WriteLine("1");
                return line;
            }
            else
            {
                line[0] = 1;
                line[number] = 1;
            }
            for (int i = 1; i < number; i++)
            {
                line[i] = prevline[i - 1] + prevline[i];
            }
            foreach (int i in line) { Console.Write($"{i} "); }
            Console.Write("\n");
            return line;
        }
    } 
}