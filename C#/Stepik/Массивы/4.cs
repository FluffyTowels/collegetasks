using System;

public class MainClass
{
    public static void Main()
    {        
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int [array.Length];
        for (int i = 0; i < array.Length; i++)
            numbers [i] = int.Parse (array [i]);      

        //Ваш код
        int summ = 0;
        foreach (int i in numbers) 
        {
            if (i % 2 == 0) {summ += i;}
        }
        Console.WriteLine(summ);
    }
}