namespace _3_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Строка: ");
            string inpt = Console.ReadLine();
            string[] words = inpt.Split(' ');
            int wordCount = 0;
            foreach (string word in words) wordCount++;
            Console.WriteLine($"Количество слов: {wordCount}");
            Console.WriteLine("Цифры: ");
            foreach (char ch in inpt) if (ch >= '0' && ch <= '9') Console.WriteLine(ch);
        }
    }
}