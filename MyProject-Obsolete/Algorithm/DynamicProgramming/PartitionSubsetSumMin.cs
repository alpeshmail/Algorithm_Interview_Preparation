using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    public class RecValue
    {
        public int Index { get; set; }
        public int Value { get; set; }

        public int CalculatedSum { get; set; }
        public int RemaningSum { get; set; }

        public int FinalResult { get; set; }

        public TravelType travelType { get; set; }
    }

    public enum TravelType
    {
        Included = 1,
         NotIncluded = 2
    }

    /// <summary>
    ///  https://leetcode.com/problems/partition-array-into-two-arrays-to-minimize-sum-difference/
    ///  https://www.educative.io/courses/grokking-dynamic-programming-patterns-for-coding-interviews/3jEPRo5PDvx
    /// </summary>
    public class PartitionSubsetSumMin
    {
        public int[] AcutalArray { get; private set; }
        public Dictionary<string, string> DicMemozaton  {get;set;}

        /// <summary>
        /// My code
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinDifferentRec(int[] nums)
        {
            int sum = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
                sum += nums[i];
            int iFinalResult = CanPartitionMinDifference(nums, nums.Length, 0, sum);
            Console.WriteLine(iFinalResult);
            return iFinalResult;
        }

        public int CanPartitionMinDifference(int[] nums,int n,int calSum,int totalsum)
        {
            if (n == 0)
                return Math.Abs(totalsum - calSum);
            int iResultIncluded = CanPartitionMinDifference(nums, n - 1, calSum + nums[n-1], totalsum - nums[n-1]);
            int iResultNotIncluded = CanPartitionMinDifference(nums, n - 1, calSum, totalsum);
            var finalResult = Math.Min(iResultIncluded, iResultNotIncluded);
            return finalResult;
        }

        // Returns the minimum value of
        // the difference of the two sets.
        public int FindMin(int[] arr)
        {
            int n = arr.Length;
            // Calculate sum of all elements
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // Create an array to store
            // results of subproblems
            bool[,] dp = new bool[n + 1, sum + 1];

            // Initialize first column as true.
            // 0 sum is possible  with all elements.
            for (int i = 0; i <= n; i++)
                dp[i, 0] = true;

            // Initialize top row, except dp[0,0],
            // as false. With 0 elements, no other
            // sum except 0 is possible
            for (int i = 1; i <= sum; i++)
                dp[0, i] = false;

            // Fill the partition table
            // in bottom up manner
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {

                    // If i'th element is excluded
                    dp[i, j] = dp[i - 1, j];

                    // If i'th element is included
                    if (arr[i - 1] <= j)
                        dp[i, j] |= dp[i - 1, j - arr[i - 1]];
                }
            }

            // Initialize difference of two sums.
            int diff = int.MaxValue;

            // Find the largest j such that dp[n,j]
            // is true where j loops from sum/2 t0 0
            for (int j = sum / 2; j >= 0; j--)
            {

                // Find the
                if (dp[n, j] == true)
                {
                    diff = sum - 2 * j;
                    break;
                }
            }
            return diff;
        }

        // Function to find the minimum sum
        private int findMinRec(int[] arr, int i,
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
        public int FindMinDistance(int[] arr)
        {
            int n = arr.Length;
            // Compute total sum of elements
            int sumTotal = 0;
            for (int i = 0; i < n; i++)
                sumTotal += arr[i];

            // Compute result using recursive function
            return findMinRec(arr, n, 0, sumTotal);
        }


        /// <summary>
        /// Copied method
        /// </summary>
        /// <returns></returns>
        public int MinDifference(int[] arr)
        {
            var newArray =ResetArrayForNagtiveNumber(arr, out int iMinValue);
            if (iMinValue < 0 && newArray != null)
                arr = newArray;
            int n = arr.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += arr[i];
            if (sum == 0)
                return 0;
            int y = sum / 2 + 1;
            // dp[i] gives whether is it possible to get i as
            // sum of elements dd is helper variable we use dd
            // to ignoring duplicates
            bool[] dp = new bool[y]; bool[] dd = new bool[y];

            // Initialising dp and dd
            for (int i = 0; i < y; i++)
            {
                dp[i] = dd[i] = false;
            }

            // sum = 0 is possible
            dd[0] = true;
            dp[0] = true;
            for (int i = 0; i < n; i++)
            {
                // updating dd[k] as true if k can be formed
                // using elements from 1 to i+1
                for (int j = 0; j + arr[i] < y; j++)
                {
                    if (dp[j])
                        dd[j + arr[i]] = true;
                }
                // updating dd
                for (int j = 0; j < y; j++)
                {
                    if (dd[j])
                        dp[j] = true;
                    dd[j] = false; // reset dd
                }
            }
            // checking the number from sum/2 to 1 which is
            // possible to get as sum

            for (int i = y - 1; i >= 0; i--)
            {
                if (dp[i])
                    return (sum - 2 * i);
                // since i is possible to form then another
                // number is sum-i so mindifference is sum-i-i
            }
            return 0;
        }

        private int[] ResetArrayForNagtiveNumber(int[] arr,out int iMinValue)
        {
            int[] AcutalArray = arr;
            iMinValue= 0;
            int[] newArray = null;
            for (int i = 0; i < AcutalArray.Length; i++)
            {
                if (AcutalArray[i] < iMinValue)
                    iMinValue = AcutalArray[i];
            }

            if (iMinValue < 0)
            {
                newArray = new int[arr.Length];
                var addingValue = iMinValue * -1;
                for (int i = 0; i < AcutalArray.Length; i++)
                    newArray[i] = AcutalArray[i] + addingValue;
            }

            return newArray;
        }
    }
}
