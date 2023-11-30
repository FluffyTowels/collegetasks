using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);

        //Тут будет Ваш код
        if (a == b) 
        {
            Console.WriteLine("a = b");
        }
        else if (a > b) 
        {
            Console.WriteLine("a > b");
        }
        else Console.WriteLine("a < b");
    }
}