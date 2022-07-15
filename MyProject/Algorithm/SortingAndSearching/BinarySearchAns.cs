using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    //Binary search can apply in unsorted array, if we have specific criteria.
    public class BinarySearchAns
    {
        /// <summary>
        ///Example:

        ///Input: array[]= {5, 10, 20, 15}
        ///Output: 20
        ///The element 20 has neighbours 10 and 15,
        ///both of them are less than 20.

        ///Input: array[] = {10, 20, 15, 2, 23, 90, 67}
        ///Output: 20 or 90
        ///The element 20 has neighbours 10 and 15, 
        ///both of them are less than 20, similarly 90 has neighbours 23 and 67.
        ///Following corner cases give better idea about the problem.

        ///If input array is sorted in strictly increasing order, the last element is always a peak element.
        ///For example, 50 is peak element in { 10, 20, 30, 40, 50}.
        ///If the input array is sorted in strictly decreasing order, 
        ///the first element is always a peak element. 100 is the peak element in { 100, 80, 60, 50, 20}.
        ///If all elements of input array are same, every element is a peak element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PeakElement(int[] nums)
        {
            int low = 0;
            int n = nums.Length;
            int high = nums.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
               
                if (mid > 0 && mid < n-1)
                {
                    if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                        return nums[mid];
                    else if (nums[mid] < nums[mid - 1])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else if (mid == 0 && nums[mid] > nums[mid + 1])
                    return nums[mid];
                else if (mid == n-1 && nums[mid] > nums[mid - 1])
                    return nums[mid];
            }

            return -1;

        }

        /// <summary>
        /// Bitonic array max value same as peak elements. since Bitonic array increasing and then decreasing value.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumElemeentInBitonicArray(int[] nums)
        {
            return PeakElement(nums);
        }

        public int FindElementInBitonicArray(int[] nums, int key)
        {
            ///Basically split array in two asc and desc then apply binary search
            int peakElement = GetPeakElementIndex(nums);
            if (peakElement == -1)
                return -1;
            if (nums[peakElement] == key)
                return peakElement;
            int decendingArrayLengh = nums.Length - peakElement;
            BinarySearch binarySearch = new BinarySearch();
            var ascResult= binarySearch.BinarySearchAsc(nums, key, 0, nums.Length - decendingArrayLengh);
            if (ascResult > -1)
                return ascResult;
            var descResult = binarySearch.BinarySearchDecending(nums, key, decendingArrayLengh, nums.Length - 1);
            return descResult;
        }
        
        private int GetPeakElementIndex(int[] nums)
        {
            int low = 0;
            int n = nums.Length;
            int high = nums.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (mid > 0 && mid < n - 1)
                {
                    if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                        return mid;
                    else if (nums[mid] < nums[mid - 1])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else if (mid == 0 && nums[mid] > nums[mid + 1])
                    return mid;
                else if (mid == n - 1 && nums[mid] > nums[mid - 1])
                    return mid;
            }
            return -1;
        }
    }
}
