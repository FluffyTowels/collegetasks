using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int minValue = 0;
        int maxValue = 0;

        //Тут будет Ваш код
        minValue = a;
        if (minValue > b)
            minValue = b;
        if (minValue > c)
            minValue = c;
        if (minValue > d)
            minValue = d;
        
        maxValue = a;
        if (maxValue < b)
            maxValue = b;
        if (maxValue < c)
            maxValue = c;
        if (maxValue < d)
            maxValue = d;



        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");

    }
}