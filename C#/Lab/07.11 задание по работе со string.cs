namespace StringWork
{
    class Prog
    {
        static void Main()
        {
            Console.Write("String: ");
            string str = Console.ReadLine();
            Console.WriteLine(Length_a(str));               //задание 1
            Console.WriteLine(NumberString(str));           //задание 2
            Console.WriteLine(NumberCountandProduct(str));  //задание 3
            Console.WriteLine(NumberConvertandDoubled(str));//задание 4
        }
        static string Length_a(string inpt)                 //задание 1
        {
            int a = 0;
            foreach (char i in inpt)
            {
                if ((i == 'a') || (i == 'A')) { a++; }
            }
            return $"{inpt.Length} {a}";
        }
        static string NumberString(string inpt)             //задание 2
        {
            string otpt = "";
            foreach (char i in inpt)
            {
                if (i >= '0' && i <= '9') { otpt += i; }
            }
            return otpt;
        }
        static string NumberCountandProduct(string inpt)    //задание 3
        {
            int cntr = 0;
            int sum = 0;
            int prdct = 1;
            foreach (char i in inpt)
            {
                if (i >= '0' && i <= '9')
                {
                    cntr++;
                    sum += Convert.ToInt32(i - '0');
                    prdct *= Convert.ToInt32(i - '0');
                }
            }
            return $"{cntr} {sum} {prdct}";
        }
        static int NumberConvertandDoubled(string inpt)     //задание 4
        {
            string otptstr = "";
            foreach (char i in inpt)
            {
                if (i >= '0' && i <= '9') { otptstr += i; }
            }
            int otptint = Convert.ToInt32(otptstr) * 2;
            return otptint;
        }
    }
}namespace StringWork
{
    class Prog
    {
        static void Main()
        {
            Console.Write("String: ");
            string str = Console.ReadLine();
            Console.WriteLine(Length_a(str));               //задание 1
            Console.WriteLine(NumberString(str));           //задание 2
            Console.WriteLine(NumberCountandProduct(str));  //задание 3
        }
        static string Length_a(string inpt)                 //задание 1
        {
            int a = 0;
            foreach (char i in inpt)
            {
                if ((i == 'a') || (i == 'A')) { a++; }
            }
            return $"{inpt.Length} {a}";
        }
        static string NumberString(string inpt)             //задание 2
        {
            string otpt = "";
            foreach (char i in inpt)
            {
                if (i >= '0' && i <= '9') { otpt += i; }
            }
            return otpt;
        }
        static string NumberCountandProduct(string inpt)    //задание 3
        {
            int cntr = 0;
            int sum = 0;
            int prdct = 1;
            foreach (char i in inpt)
            {
                if (i >= '0' && i <= '9')
                {
                    cntr++;
                    sum += Convert.ToInt32(i - '0');
                    prdct *= Convert.ToInt32(i - '0');
                }
            }
            return $"{cntr} {sum} {prdct}";
        }
    }
}