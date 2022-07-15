using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class CountSubsetsGivenSum_Test
    {

        [Fact]
        public void CountSubsets_Test1()
        {
            int[] nums = { 1, 2, 3, 3 };
            int subsetValue = 6;
            int expectedResult = 3;
            CountSubsetsGivenSum countSubsets = new CountSubsetsGivenSum();
            var acutalResult = countSubsets.GetCountSubsets(nums, subsetValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void CountSubsets_Test2()
        {
            int[] nums =  { 3, 3, 3, 3 } ;
            int subsetValue = 6;
            int expectedResult = 6;
            CountSubsetsGivenSum countSubsets = new CountSubsetsGivenSum();
            var acutalResult = countSubsets.GetCountSubsets(nums, subsetValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        
    }
}
