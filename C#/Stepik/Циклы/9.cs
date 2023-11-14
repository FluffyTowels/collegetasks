using System;

public class MainClass
{
    public static void Main()
    {      
        int n = int.Parse(Console.ReadLine());

        //Ваш код
        int hourHand = n*30;
        int minHand = 0;
        int counter = 0;
        while (minHand <= hourHand)
        {
            minHand += 30;
            if (counter % 2 == 0) { hourHand += 3; } else { hourHand += 2; }
            counter++;
        }
        if (n == 8) {hourHand += 6;}
        Console.WriteLine($"{n}:{(hourHand + 30) / 6}");

    }
}