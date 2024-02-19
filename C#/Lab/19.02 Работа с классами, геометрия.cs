using System.Runtime.Intrinsics.Arm;


namespace _19._02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Write(File.ReadAllText("text.txt"));
                string shape = "";
                bool success = false;
                while (!success)
                {
                    shape = Console.ReadLine();
                    if ((shape != "crc") && (shape != "rect") && (shape != "trig") && (shape != "sphr") && (shape != "cyl") && (shape != "prl") && (shape != "pris"))
                    {
                        Console.WriteLine("Неопознанный код.");
                        Console.Write("Код фигуры: ");
                    }
                    else success = true;
                }
                double a, b, c, r, h, S;
                S = 0;

                switch (shape)
                {
                    case "crc":
                        r = DoubleInput("Введите радиус: ");
                        S = Geometry.SurfaceArea2D(r);
                        break;
                    case "rect":
                        a = DoubleInput("Введите сторону a: ");
                        b = DoubleInput("Введите сторону b: ");
                        S = Geometry.SurfaceArea2D(a, b);
                        break;
                    case "trig":
                        a = DoubleInput("Введите сторону a: ");
                        b = DoubleInput("Введите сторону b: ");
                        c = DoubleInput("Введите сторону c: ");
                        S = Geometry.SurfaceArea2D(a, b, c);
                        break;

                    case "sphr":
                        r = DoubleInput("Введите радиус: ");
                        S = Geometry.SurfaceArea3D(r);
                        break;
                    case "cyl":
                        r = DoubleInput("Введите радиус: ");
                        h = DoubleInput("Введите высоту: ");
                        S = Geometry.SurfaceArea3D(r, h);
                        break;
                    case "prl":
                        a = DoubleInput("Введите сторону a: ");
                        b = DoubleInput("Введите сторону b: ");
                        h = DoubleInput("Введите высоту: ");
                        S = Geometry.SurfaceArea3D(a, b, h);
                        break;
                    case "pris":
                        a = DoubleInput("Введите сторону a: ");
                        b = DoubleInput("Введите сторону b: ");
                        c = DoubleInput("Введите сторону c: ");
                        h = DoubleInput("Введите высоту: ");
                        S = Geometry.SurfaceArea3D(a, b, c, h);
                        break;
                }
                if ((shape == "crc") || (shape == "rect") || (shape == "trig")) Console.Write("Площадь: ");
                else Console.Write("Площадь поверхности: ");
                Console.WriteLine(S);
                Console.Write("Выйти? (Y/N) ");
                string exstr = "";
                bool exsuccess = false;
                while (!exsuccess)
                {
                    exstr = Console.ReadLine();
                    if ((exstr != "Y") && (exstr != "N"))
                    {
                        Console.WriteLine("Неопознанный код.");
                        Console.Write("Выйти? (Y/N) ");
                    }
                    else exsuccess = true;
                }
                if (exstr ==  "Y") running = false;
                Console.Write("\n");
            }
        }
        private static double DoubleInput(string message)
        {
            bool success = false;
            double num = 0;
            while (!success)
            {
                Console.Write(message);
                success = double.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }
    }
    public class Geometry
    {
        
        public static double SurfaceArea2D(double r)
        {
            double S = System.Math.PI * r * r;
            return S;
        }

        public static double SurfaceArea2D(double a, double b)
        {
            double S = a * b;
            return S;
        }

        public static double SurfaceArea2D(double a, double b, double c)
        { 
            double p = (a + b + c) / 2;
            double S = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public static double SurfaceArea3D(double r)
        {
            double S = 4 * System.Math.PI * r * r;
            return S;
        }

        public static double SurfaceArea3D(double r, double h)
        {
            double S = 2 * System.Math.PI * r * (r + h);
            return S;
        }

        public static double SurfaceArea3D(double a, double b, double h)
        {
            double S = 2 * (a * h + a * b + b * h);
            return S;
        }
        public static double SurfaceArea3D(double a, double b, double c, double h)
        {
            double p = (a + b + c) / 2;
            double S = 2 * (System.Math.Sqrt(p * (p - a) * (p - b) * (p - c))) + a * h + b * h + c * h;
            return S;
        }
    }
}