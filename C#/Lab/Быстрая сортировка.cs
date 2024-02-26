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
            //int[] nums = { 2, 6, 5, 3, 8, 7, 1, 0 };
            //int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int checksum = 0;
            Console.Write("Array: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
                checksum += nums[i];
            }
            Console.Write("\n");
            Console.WriteLine("Checksum: " + checksum);
            int checksumSort = 0;
            QuickSort(nums, 0, nums.Length - 1);
            int numPrev = 0;
            Console.Write("Array: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < numPrev)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                Console.Write(nums[i]);
                Console.ResetColor();
                Console.Write(' ');
                checksumSort += nums[i];
                numPrev = nums[i];
            }
            Console.Write("\n");
            Console.Write("Checksum: ");
            if (checksum != checksumSort)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.Write(checksumSort);
            Console.ResetColor();
            Console.ReadKey();
        }

        static void QuickSort(int[] nums, int leftBorder, int rightBorder)
        {
            Console.Write("\n");
            Console.WriteLine("Partition: " + leftBorder + " " + rightBorder);
            if (leftBorder < rightBorder)
            {
                int partition = QSPartition(nums, leftBorder, rightBorder);
                QuickSort(nums, leftBorder, partition-1);
                QuickSort(nums, partition+1, rightBorder);
            }
            else
            {
                Console.WriteLine("Empty");
            }

        }

        static int QSPartition(int[] nums, int leftBorder, int rightBorder) 
        {
            int pivot = nums[rightBorder];
            PrintQSStep(nums, leftBorder, rightBorder);
            while (leftBorder < rightBorder)
            {
                while (nums[leftBorder] < pivot)
                {
                    
                    leftBorder++;
                    PrintQSStep(nums, leftBorder, rightBorder);
                }
                while ((nums[rightBorder] > pivot) || ((nums[rightBorder] == nums[leftBorder]) && (rightBorder != leftBorder)))
                {
                    
                    rightBorder--;
                    PrintQSStep(nums, leftBorder, rightBorder);
                }
                
                if (leftBorder >= rightBorder) break;
                (nums[leftBorder], nums[rightBorder]) = (nums[rightBorder], nums[leftBorder]);
                PrintQSStep(nums, leftBorder, rightBorder, true);
                
            }
            
            return rightBorder;
        }

        static void PrintQSStep(int[] nums, int left, int right, bool swap = false)
        {
            ConsoleColor bg = ConsoleColor.Black;
            if (swap) {  bg = ConsoleColor.DarkYellow; Console.BackgroundColor = bg; Console.ForegroundColor = ConsoleColor.Black; }
            for (int i = 0; i < nums.Length; i++)
            {
                int tempCol = 0;
                if (i == left) tempCol++;
                if (i == right) tempCol += 2;
                switch (tempCol)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Blue; break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Red; break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Magenta; break;
                }
                Console.Write(nums[i]);
                Console.BackgroundColor = bg;
                Console.Write(" ");
            }
            Console.ResetColor();
            Console.Write('\n');
        }
    }
}