using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();


        // Ваш код       
        int min = 9;
        int max = 0;
        string[] split = line.Split(' ');
        for (int i = 0; i < split.Length; i++)
        {
            if (int.Parse(split[i]) < min) { min = int.Parse(split[i]); continue; }
            if (int.Parse(split[i]) > max) { max = int.Parse(split[i]); continue; }
        }
        
        Console.WriteLine($"Наименьшее значение = {min}");
        Console.WriteLine($"Наибольшее значение = {max}");                  
    }
}