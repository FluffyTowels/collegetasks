using System;

public class MainClass
{
    public static void Main()
    {
    int number = int.Parse(Console.ReadLine());
    int count = 0;    
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else 
            {
            number *= 3;
            number += 1;
            }
            count++;
        }
        Console.WriteLine($"Количество необходимых действий над числом - {count}");       
    }
}