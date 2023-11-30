using System;

public class MainClass
{
    public static void Main()
    {
        string grades = Console.ReadLine();


        // Ваш код       
        int min = 5;
        string[] split = grades.Split(", ");
        int[] gradesArr = new int [split.Length];
        for (int i = 0; i < split.Length; i++)
            gradesArr[i] = int.Parse (split[i]);      

        for (int i = 0; i < gradesArr.Length; i++)
        { 
            if (gradesArr[i] < min) min = gradesArr[i];
        }
        switch (min)
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