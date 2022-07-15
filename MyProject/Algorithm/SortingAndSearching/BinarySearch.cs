using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    /// <summary>
    /// Regular Binary search (BinarySearchValue,BinarySearchRec
    /// https://www.geeksforgeeks.org/binary-search/
    /// Decending Binary search
    /// https://www.geeksforgeeks.org/search-an-element-in-a-reverse-sorted-array/
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// Asc order binary search
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BinarySearchAsc(int[] nums, int value)
        {
            return BinarySearchAsc(nums,nums.Length, value);
        }

        public  int BinarySearchAsc(int[] nums,int n, int value)
        {
            int high = n - 1;
            return BinarySearchAsc(nums, value, 0, high);
        }

        public int BinarySearchAsc(int[] nums, int keyValue, int low, int high)
        {
            int mid;
            int result = -1;

            while (low <= high)
            {
                //mid = (low + high) / 2;
                mid = low + (high - low) / 2;  // this is good for large int number, it will not overflow it
                if (nums[mid] == keyValue)
                {
                    result = mid;
                    break;
                }
                else if (nums[mid] > keyValue)
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
        /// Asc order binary search recursive
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BinarySearchAscRec(int[] nums, int value)
        {
            return RecBinarySearch(nums,value,0,nums.Length - 1);
        }

        private int RecBinarySearch(int[] nums, int value,int low, int high)
        {
            if (high < low)
                return -1;

            //int mid = (high + low)/2 ;
            int mid = low + (high - low) / 2;  // this is good for large int number, it will not overflow it
            if (nums[mid] == value)
                return mid;
            else if (nums[mid] > value )
            {
                return RecBinarySearch(nums, value, low, mid - 1);
            }
            else
            {
                return RecBinarySearch(nums, value, mid + 1 , high);
            }

        }

        /// <summary>
        /// Decending Order binary search
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// 
        public int BinarySearchDecending(int[] nums, int value)
        {
            return BinarySearchDecending(nums, nums.Length, value);
        }
        public int BinarySearchDecending(int[] nums,int n, int value)
        {
            int high = n - 1;
            return BinarySearchDecending(nums, value,0,high);
        }

        public  int BinarySearchDecending(int[] nums, int keyValue, int low, int high)
        {
            int mid;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (nums[mid] == keyValue)
                {
                    return mid;
                }
                else if (nums[mid] > keyValue)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public int BinarySearchNotKnow(int[] nums, int value)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == value)
                    return 0;
                else
                    return -1;
            }
            else
            {
                //Figure it out order
                //bool isDesc = false;
                //if (nums[0] > nums[nums.Length - 1])
                //    isDesc = true;
                if (nums[0] > nums[nums.Length - 1])
                {
                    //Decendending Order
                    return BinarySearchDecending(nums, value);
                }
                else
                {
                    //ascendending Order
                    return this.BinarySearchAsc(nums, value);
                }
            }
        }
    }
}
