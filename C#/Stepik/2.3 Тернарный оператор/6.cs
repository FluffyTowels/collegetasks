using System;

public class MainClass
{
    public static void Main()
    {
        int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

       //Пишите тут.
        string answer = num % 2 == 0 ? "EVEN" : "ODD";
        Console.WriteLine(answer);
    }
}