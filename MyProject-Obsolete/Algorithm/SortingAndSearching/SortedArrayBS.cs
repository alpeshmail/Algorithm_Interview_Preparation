using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    public class SortedArrayBS
    {
        /*  Given a sorted array and a value x, the floor of x is the largest element in array smaller than or equal to x. Write efficient functions to find floor of x.
        Examples: 
            Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 5
            Output : 2
            2 is the largest element in 
            arr[] smaller than 5.

            Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 20
            Output : 19
            19 is the largest element in
            arr[] smaller than 20.

            Input : arr[] = {1, 2, 8, 10, 10, 12, 19}, x = 0
            Output : -1
            Since floor doesn't exist,
            output is -1.

             */
        /// <summary>
        /// Find Floor of element
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindFloor(int[] nums,int value)
        {
            int n = nums.Length;
            int mid;
            int low = 0, high = n - 1;
            int result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == value)
                    return nums[mid];
                else if (nums[mid] >= value)
                    high = mid - 1;
                else if (nums[mid] < value)
                {
                    low = mid + 1;
                    result = nums[mid];
                }

                /*
                mid = low + (high - low) / 2;
                int prev = (mid + n - 1) % n;
                int next = (mid + 1) % n;
                if (nums[mid] == value)
                    return nums[mid];
                else if (prev >= low && next <= high && nums[prev] < value && nums[next] > value)
                    return nums[mid - 1];
                else if (nums[mid] <= value)
                    high = mid - 1;
                else
                    low = mid + 1;
                    */
            }
            return result;
        }

        public int FindCeil(int[] nums, int value)
        {
            int n = nums.Length;
            int mid;
            int low = 0, high = n - 1;
            int result = -1;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == value)
                    return nums[mid];
                else if (nums[mid] >= value)
                {
                    result = nums[mid];
                    high = mid - 1;
                }
                else if (nums[mid] < value)
                    low = mid + 1;

                /*
                mid = low + (high - low) / 2;
                int prev = (mid + n - 1) % n;
                int next = (mid + 1) % n;
                if (nums[mid] == value)
                    return nums[mid];
                else if (prev >= low && next <= high && nums[prev] < value && nums[next] > value)
                    return nums[mid - 1];
                else if (nums[mid] <= value)
                    high = mid - 1;
                else
                    low = mid + 1;
                    */
            }
            return result;
        }

        public char FindNextAlphabet(char[] chars, char cValue)
        {
            int n = chars.Length;
            int mid;
            int low = 0,high = n - 1;
            int result = -1;

            //return first values if we searching last value
            if (cValue >= chars[high])
                return chars[0];

            while(low <= high)
            {
                mid = low + (high - low) / 2;
                if(chars[mid] == cValue)
                {
                    low = mid + 1;
                }
                else if (chars[mid] > cValue)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (chars[mid] < cValue)
                    low = mid + 1;
            }
            return chars[result];
        }

        /// <summary>
        /// Find position of an element in a sorted array of infinite numbers
        /// https://www.geeksforgeeks.org/find-position-element-sorted-array-infinite-numbers/
        /// Since array is sorted, the first thing clicks into mind is binary search, but the problem here is that we don’t know size of array. 
        ///If the array is infinite, that means we don’t have proper bounds to apply binary search.So in order to find position of key, first we find bounds and then apply binary search algorithm.
        ///Let low be pointing to 1st element and high pointing to 2nd element of array, Now compare key with high index element,
        ///->if it is greater than high index element then copy high index in low index and double the high index. 
        ///->if it is smaller, then apply binary search on high and low indices found.  */
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindElementInfiniteArray(int[] nums,int value)
        {
            int start = 0, end = 1;

            ///Special logic for infinite array, After that apply regular search.
            
            while (nums[end] < value)
            {
                start = end;
                end = end * 2;
            }

            //Regular binary search
            return BinarySearch(nums, value, start, end);
        }

        public int BinarySearch(int[] nums, int value,int start,int end)
        {
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == value)
                    return mid;
                else if (nums[mid] > value)
                        end = mid - 1;
                else
                    start = mid + 1;
            }

            return -1;
        }

        public int FindFirstElementInFiniteArray(int[] nums, int value)
        {
            int start = 0, end = 1;
            while(nums[end] < value)
            {
                start = end;
                end = end * 2;
            }

            return BinarySearchFirstOccurces(nums,value,start,end);
        }

        public int BinarySearchFirstOccurces(int[] nums, int value,int start, int end)
        {
            int result = -1;
            while(start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == value)
                {
                    result = mid;
                    end = mid - 1;
                }
                else if (nums[mid] >= value)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < value)
                {
                    start = mid + 1;
                }
            }

            return result;
        }

        /// <summary>
        /// https://www.callicoder.com/minimum-difference-element-in-sorted-array/
        /// Given an array of integers sorted in ascending order, and a target value, find the element in the array that has minimum difference with the target value.
        /// Input: a[] = [2, 5, 10, 12, 15], Key = 6
        /// Output: 5
        /// </summary>
        /// <returns></returns>
        public int MinDifferenceInSortedArray(int[] nums,int key)
        {
            int high = nums.Length - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == key)
                    return nums[mid];
                else if (nums[mid] > key)
                      high = mid - 1;
                else
                    low = mid + 1;
            }

            if (low > nums.Length - 1)
                return nums[high];

            //If both are same then return low one
            if ( (high == -1  && low == 0) || (Math.Abs(nums[low] - key) < Math.Abs(nums[high] - key)))
                return nums[low];

            return nums[high];
        }
    }
}
