using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class LongestIncreasingSubsequence_Test
    {
        [Fact]
        public void LIS_1()
        {
            int[] arr = { 3, 10, 2, 1, 20 };
            var expectedResult = 3;
            LongestIncreasingSubsequence LongestIncreasingSubsequence = new LongestIncreasingSubsequence();
            int iTotal = LongestIncreasingSubsequence.LIS(arr);
            var data = LongestIncreasingSubsequence.LisValue;
            Assert.Equal(expectedResult, iTotal);
            Console.WriteLine(iTotal);
        }

        [Fact]
        public void LIS_2()
        {
            int[] arr = { 3, 2 };
            var expectedResult = 1;
            LongestIncreasingSubsequence LongestIncreasingSubsequence = new LongestIncreasingSubsequence();
            int iTotal = LongestIncreasingSubsequence.LIS(arr);
            var data = LongestIncreasingSubsequence.LisValue;
            Assert.Equal(expectedResult, iTotal);
            Console.WriteLine(iTotal);
        }


        [Fact]
        public void LIS_3()
        {
            int[] arr = { 50, 3, 10, 7, 40, 80 };
            var expectedResult = 4;
            LongestIncreasingSubsequence LongestIncreasingSubsequence = new LongestIncreasingSubsequence();
            int iTotal = LongestIncreasingSubsequence.LIS(arr);
            var data = LongestIncreasingSubsequence.LisValue;
            Assert.Equal(expectedResult, iTotal);
            Console.WriteLine(iTotal);
        }

        [Fact]
        public void LIS_4()
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 }; 
            var expectedResult = 5;
            LongestIncreasingSubsequence LongestIncreasingSubsequence = new LongestIncreasingSubsequence();
            int iTotal = LongestIncreasingSubsequence.LIS(arr);
            var data = LongestIncreasingSubsequence.LisValue;
            Assert.Equal(expectedResult, iTotal);
            Console.WriteLine(iTotal);
        }
    }
}
