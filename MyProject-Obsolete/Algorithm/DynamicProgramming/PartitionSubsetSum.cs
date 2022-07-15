using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    ///
    /// </summary>
    public class PartitionSubsetSum
    {
        public void CanPartition(int[] nums)
        {
            Dictionary<string, bool> keySets = new Dictionary<string, bool>();
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                total += nums[i];
            //if (total % 2 != 0)
            //    return false;

            //return FindRecursiveSubset(nums, 0, 0, total, total, keySets);
        }

        //two dimension matrix
        /// <summary>
        /// Haven't tested yet
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public bool CanPartition(int[] nums, int weight)
        {

            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                total += nums[i];

            bool[,] cp = new bool[weight + 1, nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++)
                cp[0, i] = true;
            for (int j = 1; j <= weight; j++)
                cp[j, 0] = false;

            for (int i = 1; i <= weight; i++)
            {
                for (int j = 1; j <= nums.Length; j++)
                {
                    if (i >= nums[j-1])
                    {
                        cp[i, j] = cp[i, j - 1] || cp[i - nums[j - 1], j - 1];
                    }
                    else
                        cp[i, j] = cp[i , j-1];
                }
            }
            
            return  cp[weight, nums.Length];
        }

        /// <summary>
        /// Returns true if arr[] can be partitioned , in two subsets of equal sum, otherwise false
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        /// Most optimize solution
        public bool FindPartiion(int[] arr, int n)
        {
            int sum = 0;
            int i, j;

            // Calculate sum of all elements
            for (i = 0; i < n; i++)
                sum += arr[i];
            if (sum % 2 != 0)
                return false;
            bool[] part = new bool[sum / 2 + 1];

            // Initialize the part array
            // as 0
            for (i = 0; i <= sum / 2; i++)
            {
                part[i] = false;
            }

            // Fill the partition table in
            // bottom up manner
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                // The element to be included
                // in the sum cannot be
                // greater than the sum
                for (j = sum / 2; j >= arr[i]; j--)
                {

                    // Check if sum - arr[i] could be
                    // formed from a subset using elements
                    // before index i
                    if (part[j - arr[i]] == true || j == arr[i])
                        part[j] = true;
                }
            }
            return part[sum / 2];
        }

    }


}


