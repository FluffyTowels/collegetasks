using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите два целых числа через пробел"); 
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int x1 = int.Parse(splitString[0]);
        int x2 = int.Parse(splitString[1]);

        int sum = x1 + x2 ; // Запишите тут Ваш код для вычисления суммы значений x1 и x2
        int difference = x1 - x2 ; // Запишите тут Ваш код для вычисления разности значений x1 и x2
        int multiply = x1 * x2 ; // Запишите тут Ваш код для вычисления произведения значений x1 и x2
        Console.WriteLine($"{sum} {difference} {multiply}"); 
    }
}