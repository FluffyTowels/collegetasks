using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        double length = Convert.ToDouble(splitString[0]); // длина
        double width = Convert.ToDouble(splitString[1]); // ширина

        //Тут будет Ваш код

        Console.WriteLine($"Площадь стола: {(length-0.2)*(width-0.2)}"); 
    }
}