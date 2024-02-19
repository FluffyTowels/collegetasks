using System.Globalization;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Длина массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = random.Next(10, 100);
            int checksum = 0;
            for (int i = 0; i < nums.Length; i ++)
            {
                Console.Write(nums[i] + " ");
                checksum += nums[i];
            }
            Console.Write("\n");
            Console.WriteLine(checksum);
            checksum = 0;
            QuickSort(nums, 0, nums.Length - 1);
            int numPrev = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < numPrev)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                Console.Write(nums[i]);
                Console.ResetColor();
                Console.Write(' ');
                checksum += nums[i];
                numPrev = nums[i];
            }
            Console.Write("\n");
            Console.WriteLine(checksum);
        }

        static void QuickSort(int[] nums, int leftBorder, int rightBorder)
        {
            if (leftBorder < rightBorder)
            {
                int pivot = QSPivot(nums, leftBorder, rightBorder);
                QuickSort(nums, leftBorder, pivot);
                QuickSort(nums, pivot + 1, rightBorder);
            }
            

        }

        static int QSPivot(int[] nums, int leftBorder, int rightBorder)
        {
            int middle = (leftBorder + rightBorder) / 2;

            while (leftBorder <= rightBorder)
            {
                while (nums[leftBorder] < nums[middle]) leftBorder++;
                while (nums[rightBorder] > nums[middle]) rightBorder--;
                if (leftBorder >= rightBorder) break;
                (nums[leftBorder], nums[rightBorder]) = (nums[rightBorder], nums[leftBorder]);
                leftBorder++;
                rightBorder--;
                
            }
            return rightBorder;
        }
    }
}