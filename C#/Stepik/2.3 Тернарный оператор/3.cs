using System;

public class MainClass
{
    public static void Main()
    {        
        int dayNumber = Convert.ToInt32(Console.ReadLine());


        //Пространство для вашего творчества

        dayNumber %= 7;
        switch (dayNumber) 
        {
            case 0:
                Console.WriteLine("Воскресенье");
                break;
            
            case 1:
                Console.WriteLine("Понедельник");
                break;
            
            case 2:
                Console.WriteLine("Вторник");
                break;
            
            case 3:
                Console.WriteLine("Среда");
                break;
            
            case 4:
                Console.WriteLine("Четверг");
                break;
            
            case 5:
                Console.WriteLine("Пятница");
                break;
            
            case 6:
                Console.WriteLine("Суббота");
                break;
        }
    }
}