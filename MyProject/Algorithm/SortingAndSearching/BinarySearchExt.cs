using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    /// <summary>
    /// using binary search find first and last element 
    /// </summary>
    public class BinarySearchExt
    {
        public int BinarySearchFirstElement(int[] nums,int value)
        {
            int length = nums.Length;
            int result = -1;
            int low = 0;
            int high = length - 1;
            int mid;

            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == value)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (nums[mid] > value)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return result;
        }

        public int BinarySearchLastElement(int[] nums, int value)
        {
            int length = nums.Length;
            int result = -1;
            int low = 0;
            int high = length - 1;
            int mid;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == value)
                {
                    result = mid;
                    //high = mid - 1;
                    low = mid + 1; //that's only difference for last elemement search
                }
                else if (nums[mid] > value)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return result;
        }

        public int CountofElements(int[] nums, int value)
        {
            var firstElement = BinarySearchFirstElement(nums, value);
            var lastElement = BinarySearchLastElement(nums, value);

            if (firstElement == -1)
                return -1;

            var result = lastElement - firstElement + 1;

            return result;
        }
    }
}
