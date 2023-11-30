using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        double length = Convert.ToDouble(splitString[0]); // длина
        double width = Convert.ToDouble(splitString[1]); // ширина
        double landArea = 0;                             // переменная для площади

        //Тут будет Ваш код
        int deduct = Convert.ToInt32(length) % 5 > 0 ? Convert.ToInt32(length) / 5 + 1 : (Convert.ToInt32(length) / 5);
        length -= deduct * 0.2;
        deduct = Convert.ToInt32(width) % 5 > 0 ? Convert.ToInt32(width) / 5 + 1 : (Convert.ToInt32(width) / 5);
        width -= deduct * 0.2;
        landArea = length * width;
        string answer = landArea.ToString("N2");
        Console.WriteLine($"Площадь участка: {answer}"); 
    }
}