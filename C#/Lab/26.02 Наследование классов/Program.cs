namespace _26._02
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Class3 cl3 = new Class3 ();
            cl3.n = Convert.ToInt32(cl3.pi);
            Console.WriteLine("cl3");
            Console.WriteLine("funcM " + cl3.funcM(cl3.n));
            Console.WriteLine("n     " + cl3.n);
            Console.Write("\n");

            Class4 cl4 = new Class4 ();
            cl4.n = 4;
            cl4.str = "Hello World";
            cl4.c = 'A';
            Console.WriteLine("cl4");
            Console.WriteLine("funcM " + cl4.funcM(cl4.n));
            Console.WriteLine("funcH " + cl4.funcH(cl4.n));
            Console.WriteLine("str   " + cl4.str);
            Console.WriteLine("c     " + cl4.c);
        }
    }
}