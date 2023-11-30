using System;

public class MainClass
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());

        // Ваш код
        int sum = 0;
        int i = startValue;
        int div;
        bool isprime;
        while (i <= endValue)
        {    
                div = 2;
                isprime = true;
                if (i>1)
                {
                    for (div = 2; div <= (i / 2); div++)
                    {
                        if (i % div == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        sum += i;
                    }
                }
            i++;
        }


        Console.WriteLine($"Сумма простых чисел = {sum}");
    }
}