using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());


        // Ваш код       
        int i = 0;
        while(i <= num) 
        {
            Console.Write($"{i} ");   
            i++;
        }
    }
}