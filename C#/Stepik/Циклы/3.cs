using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());


        // Ваш код       
        int i = 0;
        int sum = 0;
        while(sum < num) 
        {
            Console.WriteLine($"{i}");
            i++;
            sum += i; 
        }

    }
}