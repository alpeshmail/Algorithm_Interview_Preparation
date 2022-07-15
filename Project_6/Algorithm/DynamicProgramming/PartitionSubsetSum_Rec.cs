using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    /// Input:  arr[] = {1, 6, 11, 5} 
    // Output: 1 (True)
    /// This is called a DFS (Dealth first search) or Back Tracking
    /// </summary>
    public class PartitionSubsetSum_Rec
    {
        public List<int> lstResult = new List<int>();
        public bool FindSubset(int[] nums)
        {
            Dictionary<string, bool> keySets = new Dictionary<string, bool>();
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                total += nums[i];
            //if (total % 2 != 0)
            //    return false;

            return FindRecursiveSubset(nums, 0,0, total, total, keySets);
        }

        public bool FindSubset(int[] nums,int weight)
        {
            Dictionary<string, bool> keySets = new Dictionary<string, bool>();
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                total += nums[i];
            var result= FindRecursiveSubset(nums, 0,0, total, weight, keySets);
            return result;
        }

        private bool FindRecursiveSubset(int[] nums,int index,int caltotal,int remaningTotal,int weight, Dictionary<string, bool> keySets)
        {
            //already exists state then return
            string current = index.ToString() + "_" + caltotal.ToString();
            if (keySets.ContainsKey(current))
                return keySets[current];
          
            if (index > nums.Length)
                return false;
            if (caltotal == weight)
            {
                //lstResult.Add(nums[index]);
                return true;
            }
            if (remaningTotal < weight || caltotal > weight)
              return false;
            //current numebr is included
            var bResult = FindRecursiveSubset(nums, index + 1, caltotal + nums[index], remaningTotal - nums[index], weight, keySets);
            if (bResult)
                lstResult.Add(nums[index]);
            //current no is not incuded
            if (!bResult)
                bResult=FindRecursiveSubset(nums, index + 1, caltotal, remaningTotal - nums[index], weight, keySets);
            //store state
            keySets[current] = bResult;
            return bResult;
        }
    }

    public class GFG_Rec
    {

        // Function to find the minimum sum
        public static int findMinRec(int[] arr, int i,
                                     int sumCalculated,
                                     int sumTotal)
        {
            // If we have reached last element.
            // Sum of one subset is sumCalculated,
            // sum of other subset is sumTotal-
            // sumCalculated. Return absolute
            // difference of two sums.
            if (i == 0)
                return Math.Abs((sumTotal - sumCalculated)
                                - sumCalculated);

            // For every item arr[i], we have two choices
            // (1) We do not include it first set
            // (2) We include it in first set
            // We return minimum of two choices
            return Math.Min(
                findMinRec(arr, i - 1,
                           sumCalculated + arr[i - 1],
                           sumTotal),
                findMinRec(arr, i - 1, sumCalculated,
                           sumTotal));
        }

        // Returns minimum possible difference between
        // sums of two subsets
        public static int findMin(int[] arr)
        {
            int n = arr.Length;

            // Compute total sum of elements
            int sumTotal = 0;
            for (int i = 0; i < n; i++)
                sumTotal += arr[i];

            // Compute result using recursive function
            return findMinRec(arr, n, 0, sumTotal);
        }

        ///* Driver program to test above function */
        //public static void Main()
        //{
        //    int[] arr = { 3, 1, 4, 2, 2, 1 };
        //    int n = arr.Length;
        //    Console.Write("The minimum difference"
        //                  + " between two sets is "
        //                  + findMin(arr, n));
        //}
    }
}
