using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = new int[2] {1, 3};
            //var t = Search(tmp, 0);

            var t = SearchRotatedArray(tmp, 3);

            //var tmp2 = GuessNumber(2126753390);

            //Console.WriteLine(tmp2);
            Console.WriteLine(t);
        }

        //https://leetcode.com/problems/binary-search/submissions/
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

        //https://leetcode.com/problems/guess-number-higher-or-lower/
        public static int GuessNumber(int n)
        {
            long left = 0;
            long right = n;

            while (true)
            {
                int middle = (int) ((left + right) / 2);
                var result = guess(middle);
                if (result == 0)
                {
                    return middle;
                }
                else
                {
                    if (result == -1)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

            }
        }

        public static int guess(long number)
        {
            if (1702766719 == number)
            {
                return 0;
            }

            if (1702766719 < number)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        //https://leetcode.com/problems/search-a-2d-matrix/submissions/
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var indexAppropriateArray = SearchArrayIndexWhereExistValue(matrix, target);

            return CheckForExist(matrix[indexAppropriateArray], target);
        }

        private int SearchArrayIndexWhereExistValue(int[][] matrix, int target)
        {
            var rowSize = matrix[0].Length;
            int leftIndex = 0;
            int rightIndex = matrix.Length;
            while (leftIndex < rightIndex)
            {
                int middleIndex = (rightIndex + leftIndex) / 2;
                var maxValueInArrayByMiddleIndex = matrix[middleIndex][rowSize - 1];
                var minValueInArrayByMiddleIndex = matrix[middleIndex][0];

                if (maxValueInArrayByMiddleIndex >= target && minValueInArrayByMiddleIndex <= target)
                {
                    return middleIndex;
                }

                if (maxValueInArrayByMiddleIndex < target)
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

        private bool CheckForExist(int[] arr, int target)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length;

            while (leftIndex < rightIndex)
            {
                int middleIndex = (rightIndex + leftIndex) / 2;
                var valueByMiddleIndex = arr[middleIndex];

                if (valueByMiddleIndex == target)
                {
                    return true;
                }

                if (valueByMiddleIndex < target)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex;
                }
            }

            return false;
        }

        //https://leetcode.com/problems/search-in-rotated-sorted-array/submissions/
        public static int SearchRotatedArray(int[] nums, int target)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length-1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (rightIndex + leftIndex) / 2;
                var valueByMiddleIndex = nums[middleIndex];

                if (valueByMiddleIndex == target)
                {
                    return middleIndex;
                }

                if (nums[leftIndex] <= valueByMiddleIndex)
                {
                    if (nums[leftIndex] <= target && valueByMiddleIndex > target)
                    {
                        rightIndex = middleIndex;
                    }
                    else
                    {
                        leftIndex = middleIndex + 1;
                    }
                }
                else
                {
                    if (nums[rightIndex] >= target && valueByMiddleIndex < target)
                    {
                        leftIndex = middleIndex + 1;
                    }
                    else
                    {
                        rightIndex = middleIndex;
                    }
                }
            }

            return -1;
        }
    }
}
