using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    public class CountSubsetsGivenDifference
    {
        public int GetCountSubsetsRecursive(int[] nums, int difference)
        {
            Dictionary<string, bool> keySets = new Dictionary<string, bool>();
            var result= FindRecursiveSubset(nums, 0, 0, difference, keySets);
            return result;
        }

        private int FindRecursiveSubset(int[] nums, int index, int caltotal, int difference, Dictionary<string, bool> keySets)
        {
            //already exists state then return
            //string current = index.ToString() + "_" + caltotal.ToString();
            //if (keySets.ContainsKey(current))
            //    return keySets[current];

            if (index > nums.Length - 1)
            {
                if (caltotal == difference)
                    return 1;
                return 0;
            }
              //current numebr is included
            var iIncludedResult = FindRecursiveSubset(nums, index + 1, caltotal + nums[index], difference, keySets);
            var iNotIncludedResult = FindRecursiveSubset(nums, index + 1, caltotal - nums[index], difference, keySets);
            var totalResult = iIncludedResult + iNotIncludedResult;
            //store state
            //keySets[current] = totalResult;
            return totalResult;
        }

        public int GetCountSubsetsDynamically(int[] nums, int difference)
        {
            //For dynamically programming,
            //Convert this problem to count of subsets given sum.
            //to convert do (difference+ sum) / 2 = given sum

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            int calSumValue = (difference + sum) / 2;

            CountSubsetsGivenSum countSubsetsGivenSum = new CountSubsetsGivenSum();
            var returnValue = countSubsetsGivenSum.GetCountSubsets(nums, calSumValue);
            Console.WriteLine(returnValue);
            return returnValue;
        }
    }
}
