using System;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();


        // Ваш код       
        bool broke = false;
        for (int i = 0; i < (num1.Length - 1); i++)
        {
            broke = false;
            
            for (int j = 0; j < num1.Length; j++)
            {
                if ((num1[j] == num1[i]) && !(i == j)) {broke = true; break;}
            }
            if (broke) {continue;}
            
            for (int j = 0; j < num2.Length; j++)
            {
                if (num2[j] == num1[i]) {broke = true; break;}
            }
            if (broke) {continue;}
            
            Console.WriteLine($"Уникально число {num1[i]}");
        }
        
    }
}