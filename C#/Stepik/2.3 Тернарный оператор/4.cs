using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());
        
        switch (operation) 
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
                
            case 2:
                Console.WriteLine("Вычитание");
                break;
                
            case 3:
                Console.WriteLine("Умножение");
                break;
                
            case >3:
            case <1:
                Console.WriteLine("Неизвестная операция!");
                break;
        }




    }
}