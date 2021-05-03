using System;
namespace SimpleSearch
{
    public class Solution
    {
        public Solution()
        {
        }

        
        public int BinarySearch(int[] nums,int searchValue)
        {
            int result = 0;
            int left = 0;
            int right = nums.Length - 1;
            int middle = 0;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (nums[middle] < searchValue)
                    left = middle + 1;
                else if (nums[middle] > searchValue)
                    right = middle - 1;
                else
                {
                    result = middle;
                    break;
                }

            }
            return result;
        }
    }
}
