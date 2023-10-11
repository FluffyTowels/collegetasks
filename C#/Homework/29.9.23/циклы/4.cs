using System;
namespace svntndiv
{
    class Prog
    {
        static void Main()
        {
            int num = 200;
            while(true)
            {
                if (num % 17 == 0)
                {
                    Console.WriteLine(num);
                    break;
                }
                num++;
            }
        }
    }
}