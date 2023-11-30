using System;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();


        // Ваш код 
        int matchcnt = 0;
        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] == num2[i]) {matchcnt++;}
        }
        Console.WriteLine($"Совпадение {matchcnt} элементов");
    }
}