using System;

public class MainClass
{
    public static void Main()
    {      
        int height = int.Parse(Console.ReadLine());

        //Пространство для вашего творчества
        int j;
        for (int i = 1; i <= height; i++)
        {
            for (j = 1; j <= (height-i);j++)
            {
                Console.Write(" ");
            }
            for (j = 1; j <= (2*i - 1); j++)
            {
                Console.Write("*");
            }
            Console.Write($"\n");  
        }
    }
}