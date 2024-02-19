using System.ComponentModel;
using System.Runtime.InteropServices;

namespace _06._02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            InputNums(ref a, ref b);
            int sum = IntSum(a, b);
            int mult = IntMult(sum, ref c);
            Output(sum, mult);
            Console.WriteLine("---------\n");
            
            OutputArr(IntMultArr(IntSumArr(InputNumsArr())));
            Console.ReadKey();
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

        private static void InputNums(ref int a, ref int b )
        {
            a = IntInput("a = ");
            b = IntInput("b = ");
        }
        
        private static int IntSum (int a, int b)
        { 
            return a + b; 
        }

        private static int IntMult (int sum, ref int c)
        {
            c = IntInput("c = ");
            return sum * c;
        }

        private static void Output (int sum, int mult)
        {
            Console.WriteLine($"Сумма a + b = {sum} \nПроизведение (a + b) * c = {mult}");
        }

        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------

        private static int[] InputNumsArr()
        {
            int[] nums = new int[2];
            nums[0] = IntInput("a = ");
            nums[1] = IntInput("b = ");
            return nums;
        }

        private static  int[] IntSumArr(int[] nums)
        {
            nums[1] = nums[0] + nums[1];
            return nums;
        }

        private static int[] IntMultArr(int[] nums)
        {
            nums[0] = IntInput("c = ") * nums[1];
            return nums;
        }

        private static void OutputArr(int[] nums) 
        {
            Console.WriteLine($"Сумма a + b = {nums[1]} \nПроизведение (a + b) * c = {nums[0]}");
        }
    }
}