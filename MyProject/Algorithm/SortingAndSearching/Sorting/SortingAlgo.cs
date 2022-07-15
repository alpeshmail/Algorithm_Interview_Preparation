using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching.Sorting
{
    public class SortingAlgo
    {

        #region Bubble Sort
        //Consider an array arr[] = {5, 1, 4, 2, 8}
        public int[] BubbleSort(int[] nums)
        {
            int temp;
            int n = nums.Length -1;
            for (int i=0;i <= n; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < n; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        isSwapped = true;
                    }
                }

                ///isSwipeInd is used for optimize version, if array is already sorted then we can exists it.
                if (!isSwapped)
                    break;
            }

            return nums;
        }

        #endregion Bubble Sort

        #region Insertion Sort

        public int[] InsertionSort(int[] nums)
        {
            int temp;
            int n = nums.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;

                    for (int j = i; j > 0; j--)
                    {
                        if (nums[j - 1] > nums[j])
                        {
                            temp = nums[j];
                            nums[j] = nums[j - 1];
                            nums[j - 1] = temp;
                        }
                        else
                            break;
                    }
                }
            }

            return nums;
        }

        #endregion Insertion Sort

        #region Merge Sort

        public int[] MergeSort(int[] nums)
        {
            int n = nums.Length;
            MergeSort(nums, 0, n - 1);
            return nums;
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        private void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = l + (r - l) / 2;

                // Sort first and
                // second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                Merge(arr, l, m, r);
            }
        }

        private void Merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        #endregion Merge Sort

        #region Quick Sort

        public int[] QuickSort(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
            return nums;
        }

        private void QuickSort(int[] nums,int low,int high)
        {
            if (low < high)
            {
                int pivot = Partition(nums, low, high);
                QuickSort(nums, low, pivot - 1);
                QuickSort(nums, pivot+1, high);
            }
        }

        private int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            int i = low;
            int j = high;

            while (i < j)
            {
                while (pivot >= nums[i])
                    i++;
                while (pivot < nums[j])
                    j--;
                if (i < j)
                    QuickSortSwapped(nums, i, j);
            }

            QuickSortSwapped(nums, low, j);
            return j;
        }

        private void QuickSortSwapped(int[] nums,int i,int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        #endregion Quick Sort
    }
}
