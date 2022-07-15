using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    public class CountSubsetsGivenSum
    {

        public int GetCountSubsets(int[] nums,int subsetSumValue)
        {
            Dictionary<string, bool> keySets = new Dictionary<string, bool>();
            //var result= FindRecursiveSubset(nums, 0, 0,  subsetValue, keySets);
            var result = CanPartition(nums, subsetSumValue); 

            return result;
        }

        public int CanPartition(int[] nums, int subsetSumValue)
        {

            int total = 0;
            for (int i = 0; i < nums.Length; i++)
                total += nums[i];

            int[,] cp = new int[subsetSumValue + 1, nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++)
                cp[0, i] = 1;
            for (int j = 1; j <= subsetSumValue; j++)
                cp[j, 0] = 0;

            for (int i = 1; i <= subsetSumValue; i++)
            {
                for (int j = 1; j <= nums.Length; j++)
                {
                    if (i >= nums[j - 1])
                    {
                        //cp[i, j - 1] -- not incouded condition
                        //cp[i - nums[j - 1], j - 1] -- included condition
                        cp[i, j] = cp[i, j - 1] + cp[i - nums[j - 1], j - 1];
                    }
                    else
                        cp[i, j] = cp[i, j - 1];
                }
            }

            return cp[subsetSumValue, nums.Length];
        }


        public int FindRecursiveSubset(int[] nums, int index, int caltotal, int subsetValue, Dictionary<string, bool> keySets)
        {
            //already exists state then return
            //string current = index.ToString() + "_" + caltotal.ToString();
            //if (keySets.ContainsKey(current))
            //    return keySets[current];

            if (index > nums.Length - 1)
                return 0;
            if (caltotal == subsetValue)
            {
                var result = 1 + FindRecursiveSubset(nums, index + 1, 0, subsetValue, keySets);
                //lstResult.Add(nums[index]);
                return result;
            }
            if (caltotal > subsetValue)
            {
                var result = FindRecursiveSubset(nums, index + 1, 0, subsetValue, keySets);
                return result;
            }
            //current numebr is included
            var iIncludedResult = FindRecursiveSubset(nums, index + 1, caltotal + nums[index], subsetValue, keySets);
            var iNotIncludedResult = FindRecursiveSubset(nums, index + 1, caltotal, subsetValue, keySets);
            var totalResult = iIncludedResult + iNotIncludedResult;
            //store state
            //keySets[current] = totalResult;
            return totalResult;
        }
    }
}
