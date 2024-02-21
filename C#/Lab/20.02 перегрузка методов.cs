namespace _20._02_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IntSum();
            DoubleSum();
            ArrSum();
            StringSum();
            Console.ReadKey();
        }

        private static void IntSum ()
        {
            int intsumcomponent1 = IntInput("Введите первый int: ");
            int intsumcomponent2 = IntInput("Введите второй int: ");
            int intsumcomponent3 = IntInput("Введите третий int: ");
            Console.WriteLine($"{intsumcomponent1} + {intsumcomponent2} = {Sum(intsumcomponent1, intsumcomponent2)}");
            Console.WriteLine($"{intsumcomponent1} + {intsumcomponent2} + {intsumcomponent3} = {Sum(intsumcomponent1, intsumcomponent2, intsumcomponent3)}");
        }

        private static void DoubleSum()
        {
            double doublesumcomponent1 = DoubleInput("Введите первый double: ");
            double doublesumcomponent2 = DoubleInput("Введите второй double: ");
            Console.WriteLine($"{doublesumcomponent1} + {doublesumcomponent2} = {Sum(doublesumcomponent1, doublesumcomponent2)}");
        }

        private static void ArrSum()
        {
            int[] nums = new int[IntInput("Введите длину массива: ")];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = IntInput($"Введите nums[{i}]: ");
            }
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                if (i < nums.Length - 1) Console.Write(" + ");
                else Console.Write(" = ");
            }
            Console.WriteLine(Sum(nums));
        }

        private static void StringSum()
        {
            Console.Write("Введите первый string: ");
            string stringsumcomponent1 = Console.ReadLine();
            Console.Write("Введите второй string: ");
            string stringsumcomponent2 = Console.ReadLine();
            Console.WriteLine(Sum(stringsumcomponent1, stringsumcomponent2));
        }

        private static int IntInput(string message)
        {
            bool success = false;
            int num = 0;
            while (!success)
            {
                Console.Write(message);
                success = Int32.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }
        private static double DoubleInput(string message)
        {
            bool success = false;
            double num = 0;
            while (!success)
            {
                Console.Write(message);
                success = Double.TryParse(Console.ReadLine(), out num);
                if (!success) Console.WriteLine("Не число");
            }
            return num;
        }

        private static int Sum(int intsumcomponent1, int intsumcomponent2)
        {
            return intsumcomponent1 + intsumcomponent2;
        }

        private static int Sum(int intsumcomponent1, int intsumcomponent2, int intsumcomponent3)
        {
            return intsumcomponent1 + intsumcomponent2 + intsumcomponent3;
        }

        private static double Sum(double doublesumcomponent1, double doublesumcomponent2)
        {
            return doublesumcomponent1 + doublesumcomponent2;
        }

        private static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums) sum += num;
            return sum;
        }

        private static string Sum (string stringsumcomponent1, string stringsumcomponent2) 
        {
            return stringsumcomponent1 + stringsumcomponent2;
        }
    }

}