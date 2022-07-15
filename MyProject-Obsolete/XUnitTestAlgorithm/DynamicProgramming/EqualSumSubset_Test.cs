using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class EqualSumSubset_Test
    {
        [Fact]
        public void EqualSumSubset_Test1()
        {
            int[] num = { 1, 5, 11, 5 };
            var expetedResult = true;
            EqualSumSubset EqualSumSubset = new EqualSumSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);
            var result = EqualSumSubset.CanPartitionByEqualSum(num);

            Console.WriteLine(result);
            Assert.Equal(expetedResult, result);

        }

        [Fact]
        public void EqualSumSubset_Test2()
        {
            int[] num = { 1,2,3,5};
            var expetedResult = false;
            EqualSumSubset EqualSumSubset = new EqualSumSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);
            var result = EqualSumSubset.CanPartitionByEqualSum(num);

            Console.WriteLine(result);
            Assert.Equal(expetedResult, result);

        }
    }
}
