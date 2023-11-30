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

        int minValue = 0;

        //Тут будет Ваш код
        minValue = a;
        if (minValue > b)
            minValue = b;
        if (minValue > c)
            minValue = c;

        Console.WriteLine(minValue);
    }
}