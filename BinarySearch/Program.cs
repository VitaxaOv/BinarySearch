using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = new int[6] {-1, 0, 3, 5, 9, 12};
            var t = Search(tmp, 9);

            Console.WriteLine(t);
        }

        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0 || nums[0] > target)
            {
                return -1;
            }

            int leftIndex = 0;
            int rightIndex = nums.Length;

            while (leftIndex < rightIndex)
            {
                int middleIndex = (rightIndex + leftIndex) / 2;

                if (nums[middleIndex] == target)
                {
                    return middleIndex;
                }

                if (nums[middleIndex] < target)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }

            }

            return -1;
        }
    }
}
