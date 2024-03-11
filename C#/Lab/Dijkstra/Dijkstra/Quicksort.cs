namespace Dijkstra
{
    public class Quicksort
    {

        public static void QuickSort(int[] nums, int leftBorder, int rightBorder)
        {
            if (leftBorder < rightBorder)
            {
                int partition = QSPartition(nums, leftBorder, rightBorder);
                QuickSort(nums, leftBorder, partition-1);
                QuickSort(nums, partition+1, rightBorder);
            }
        }

        private static int QSPartition(int[] nums, int leftBorder, int rightBorder) 
        {
            int pivot = nums[rightBorder];
            while (leftBorder < rightBorder)
            {
                while (nums[leftBorder] < pivot)
                {                    
                    leftBorder++;
                }
                while ((nums[rightBorder] > pivot) || ((nums[rightBorder] == nums[leftBorder]) && (rightBorder != leftBorder)))
                {                    
                    rightBorder--;
                }
                if (leftBorder >= rightBorder) break;
                (nums[leftBorder], nums[rightBorder]) = (nums[rightBorder], nums[leftBorder]); 
            }           
            return rightBorder;
        }
    }
}