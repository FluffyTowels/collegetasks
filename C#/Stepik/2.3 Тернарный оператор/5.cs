using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int operation = Convert.ToInt32(splitString[0]);
        double a = Convert.ToDouble(splitString[1]);
        double b = Convert.ToDouble(splitString[2]);
        double result = 0;

        //Ваш код
        
        switch (operation) 
        {
            case 1:
                result = a + b;
                Console.WriteLine($"Результат операции {result}");
                break;
                
            case 2:
                result = a - b;
                Console.WriteLine($"Результат операции {result}");
                break;
                
            case 3:
                result = a * b;
                Console.WriteLine($"Результат операции {result}");
                break;
                
            case >3:
            case <1:
                Console.WriteLine("Неизвестная операция!");
                break;
        }






    }
}