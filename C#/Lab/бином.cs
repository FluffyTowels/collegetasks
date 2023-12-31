using System;
namespace doubleloop
{
    class Prog
    {
        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine()); 				//номер строки
            Console.Write($"\n");
            int[] a = BinomLine(n);								//вызов функции, которая выводит только строку n и сохранение её результата в массив
            Console.WriteLine("BinomLine: ");
            foreach (int i in a) { Console.Write($"{i} "); }	//печать массива
            Console.WriteLine($"\n");							
            Console.WriteLine("BinomPrint: ");
            BinomPrint(n);										//вызов функции которая печатает треугольник включительно до строки n
        }
        
        
        static int[] BinomLine(int number)
        {
            if (number < 0) { int[] a = { 1 }; return a; }		//если n = -1, вернуть массив {1}
            int[] prevline = BinomLine(number - 1);				//вызов функции чтобы вычислить предыдущую строку
            int[] line = new int[number+1];						//создание пустого массива для текущей строки
            if (number == 0)									//если n = 0 
            {
                line[0] = 1;									//line = {1}
                return line;									//вернуть line(массив)
            }
            else												//иначе (n > 0)
            {
                line[0] = 1;									//первое число в массиве - 1
                line[number] = 1;								//последние число в массиве - 1
            }
            for (int i = 1; i < number; i++)					//вычисление остальных элементов массива
            {													//вычисление остальных элементов массива
                line[i] = prevline[i-1] + prevline[i];			//вычисление остальных элементов массива
            }													//вычисление остальных элементов массива
            return line;										//вернуть line(массив)
        }
        
        
        static int[] BinomPrint(int number)						//метод такой же как и выше, кроме строчек которые печатают строки треугольника
        {
            if (number < 0) { int[] a = { 1 }; return a; }
            int[] prevline = BinomPrint(number - 1);
            int[] line = new int[number + 1];
            if (number == 0)
            {
                line[0] = 1;
                Console.WriteLine("1");
                return line;
            }
            else
            {
                line[0] = 1;
                line[number] = 1;
            }
            for (int i = 1; i < number; i++)
            {
                line[i] = prevline[i - 1] + prevline[i];
            }
            foreach (int i in line) { Console.Write($"{i} "); }	//печатает строку треугольника
            Console.Write("\n");								//печатает строку треугольника
            return line;
        }
    } 
}