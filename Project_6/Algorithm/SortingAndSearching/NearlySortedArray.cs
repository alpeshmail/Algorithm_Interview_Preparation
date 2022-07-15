using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    public class NearlySortedArray
    {

        public int FindElement(int[] nums,int value)
        {
            int mid;
            int n = nums.Length;
            int low = 0, high = n - 1;
            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == value)
                    return mid;
                else if (mid > low && nums[mid - 1] == value)
                    return (mid - 1);
                else if (mid < high && nums[mid + 1] == value)
                    return (mid + 1);
                else if (nums[mid] >= value)
                    high = mid - 2;
                else if (nums[mid] <= value)
                    low = mid + 2;
            }
            
            return -1;
        }
    }
}
