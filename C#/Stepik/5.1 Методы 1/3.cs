public static void Factorize(int number)
{    

    //Пишите тело вашего метода здесь 
                int bmin = 10000;
                for (int i = 1; i < bmin; i++)
                {
                    if (number / i < bmin)
                    {
                        bmin = number / i;
                    }
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{number} = {i} * {number / i}");
                    }
                }

}