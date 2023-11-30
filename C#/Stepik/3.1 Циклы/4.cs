using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());


        // Ваш код
        int prod = 1;
        for (int i = 1; i <= num; i++)
        {
            prod *= i;
        }
        Console.WriteLine(prod);
    }
}