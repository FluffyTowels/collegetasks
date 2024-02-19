namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            double c = a + b;
            int whole = Convert.ToInt32(c);
            double frac = c - Convert.ToDouble(whole);
            Console.WriteLine($"Цельная часть суммы: {whole}");
            Console.WriteLine($"Дробная часть суммы: {frac}");
        }
    }
}