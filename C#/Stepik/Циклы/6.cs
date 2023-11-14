using System;

public class MainClass
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        // Ваш код       
        string firstString = Convert.ToString(firstNumber);
        string secondString = Convert.ToString(secondNumber);
        char match = 'a';
        bool matchFound = false;
        foreach (char i in firstString) 
        {
            foreach (char j in secondString) 
            {
                if (i == j)
                {
                    match = i;
                    matchFound = true;
                    break;
                }
            }
            if (matchFound) {break;}
        }
        foreach (char i in firstString) 
        {
            if (i == match) {Console.Write($"{i} ");}
        }

    }
}