using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    /// Equal sum partition by K Subset or partition by 2 subsets.
    /// if partitino by 2 subsets, means sum/2
    /// </summary>
    public class EqualSumSubset
    {
        public bool CanPartitionByEqualSum(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
                sum += num[i];
            if (sum % 2 != 0)
                return false;
            int targetValue = sum / 2;
            PartitionSubsetSum partitionSubsetSum = new PartitionSubsetSum();
            var result = partitionSubsetSum.CanPartition(num, targetValue);
            Console.WriteLine(result);
            return result;
        }
    }
}
