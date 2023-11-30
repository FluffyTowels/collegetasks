using System;

public class MainClass
{
    public static void Main()
    {
        string grades = Console.ReadLine();


        // Ваш код       
        int switchcase = 5;
        string[] split = grades.Split(", ");
        for (int i = 0; i < split.Length; i++)
        { 
            if (split[i] == "2") {switchcase = 2; break;}
            if ((split[i] == "3") && (switchcase > 3)) {switchcase = 3;}
            if ((split[i] == "4") && (switchcase > 4)) {switchcase = 4;}
        }
        switch (switchcase)
        {
            case 2:
                Console.WriteLine("Ну что, студент, пора долг Родине отдать");
                break;
            case 3:
                Console.WriteLine("Прощай стипендия!");
                break;
            case 4:
                Console.WriteLine("Живи пока, через полгода увидимся");
                break;
            case 5:
                Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
                break;
        }
    }
}