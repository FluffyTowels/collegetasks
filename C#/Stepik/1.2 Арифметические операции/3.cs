using System;

public class MainClass
{
    public static void Main()
    {        
        Console.WriteLine("Введите пройденное расстояние в метрах");
        int n = Convert.ToInt32(Console.ReadLine()); // преобразуем введенную строку в число 
                                                     // и присваиваем его значение переменной

        int distance = 1000 - (n % 1000); //Запишите тут Ваш код для вычислений

        Console.WriteLine(distance); 
    }
}