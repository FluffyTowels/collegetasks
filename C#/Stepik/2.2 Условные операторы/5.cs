using System;

public class MainClass
{
    public static void Main()
    {
        double bankDeposit = Convert.ToDouble(Console.ReadLine());
        double sum = 0.0;



        //Тут будет Ваш код
        if (bankDeposit < 100) 
        {
            sum = bankDeposit * 1.05;
        }
        
        if (bankDeposit >= 100 && bankDeposit <= 200) 
        {
            sum = bankDeposit * 1.07;
        }
        
        if (bankDeposit > 200) 
        {
            sum = bankDeposit * 1.10;
        }

        Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");

    }
}