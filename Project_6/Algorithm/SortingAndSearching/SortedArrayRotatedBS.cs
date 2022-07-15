using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    public class SortedArrayRotatedBS
    {
        public int NumberOfTimesArrayRoated(int[] nums)
        {
            int n = nums.Length;
            int mid;
            int high = n -1 ;
            int low = 0;int next;int prev;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                next = (mid + 1) % n;
                prev = (mid +n - 1) % n;
                
                if (nums[mid] <= nums[prev]  && nums[mid] <= nums[next])
                {
                    return mid;
                }
                else if (nums[mid] <= nums[high])
                {
                    high = mid - 1; 
                }
                else if (nums[mid] >= nums[low] )
                {
                    low = mid + 1;
                }
            }

            return 0;
        }

        public int FindElement(int[] nums,int value)
        {
            int minElements = NumberOfTimesArrayRoated(nums);
            if (minElements < 1)
                return -1;
            if (value == nums[minElements])
                return minElements;
            if (value > nums[0])
            {
                int iResultFirstArray = BinarySearchAsc(nums, 0, minElements - 1, value);
                return iResultFirstArray;
            }
            else
            {
                int iResultSecondArray = BinarySearchAsc(nums, minElements, nums.Length - 1, value);
                return iResultSecondArray;
            }
        }

        private int BinarySearchAsc(int[] nums, int low,int high, int value)
        {
            int mid;
            int result = -1;

            while (low <= high)
            {
                //mid = (low + high) / 2;
                mid = low + (high - low) / 2;  // this is good for large int number, it will not overflow it
                if (nums[mid] == value)
                {
                    result = mid;
                    break;
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

        /// <summary>
        /// Number of Times a Sorted array is Rotated, little differnt
        /// </summary>
        /// <returns></returns>
        public int NumberOfTimesArrayRoatedDifferentCode(int[]  nums)
        {
            int length = nums.Length - 1;
            int mid;
            int high = length;
            int low = 0;
            int result = 0;
            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if ((mid == length - 1) && nums[mid+1] < nums[mid])
                {
                    return (mid + 1);
                }
                else if (nums[mid] < nums[mid-1] && nums[mid] < nums[mid + 1])
                {
                    return mid;
                }
                else if (nums[mid] > nums[low])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }
    }
}
