using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    /// <summary>
    /// [709,374,1492,1279,2848,6337,365,1923,739,1904,1938,4627,1106,5885,1202]
    // 4
    // Leetcode expected true, but my code return false.
    /// </summary>
    public class EqualSumKSubset_Test
    {
        [Fact]
        public void EqualSumKSubset_Test1()
        {
            int[] num = { 4, 3, 2, 3, 5, 2, 1 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);
            
            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_DP_Test1()
        {
            int[] num = { 4, 3, 2, 3, 5, 2, 1 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);

            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_Test11()
        {
            int[] num = { 709, 374, 1492, 1279, 2848, 6337, 365, 1923, 739, 1904, 1938, 4627, 1106, 5885, 1202 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            // var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);

            //copy greek code
            //GFG_EqualSumKSubset gFG_EqualSumKSubset = new GFG_EqualSumKSubset();
            //var result = gFG_EqualSumKSubset.isKPartitionPossible(num, num.Length, partition);
            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);
            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_DP_Test11()
        {
            int[] num = { 709, 374, 1492, 1279, 2848, 6337, 365, 1923, 739, 1904, 1938, 4627, 1106, 5885, 1202 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            // var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);

            //copy greek code
            //GFG_EqualSumKSubset gFG_EqualSumKSubset = new GFG_EqualSumKSubset();
            //var result = gFG_EqualSumKSubset.isKPartitionPossible(num, num.Length, partition);
            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);
            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_Test12()
        {
            //This should be false.
            int[] num = {2,2,2,2,3,4,5 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);

            //GFG_EqualSumKSubset gFG_EqualSumKSubset = new GFG_EqualSumKSubset();
            //var result = gFG_EqualSumKSubset.isKPartitionPossible(num, num.Length,partition);

            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);

            Console.WriteLine(result);
            Assert.False(result);

        }

        [Fact]
        public void EqualSumKSubset_DP_Test12()
        {
            //This should be false.
            int[] num = { 2, 2, 2, 2, 3, 4, 5 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet(num, partition);

            //GFG_EqualSumKSubset gFG_EqualSumKSubset = new GFG_EqualSumKSubset();
            //var result = gFG_EqualSumKSubset.isKPartitionPossible(num, num.Length,partition);

            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);

            Console.WriteLine(result);
            Assert.False(result);

        }

        [Fact]
        public void EqualSumKSubset_Test2()
        {
            int[] num = { 4, 3, 2, 3, 5, 2, 1 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);
            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_DP_Test2()
        {
            int[] num = { 4, 3, 2, 3, 5, 2, 1 };
            int partition = 4;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);
            Console.WriteLine(result);
            Assert.True(result);

        }

        [Fact]
        public void EqualSumKSubset_Test_3()
        {
            int[] num = { 2, 1, 5, 5, 6 };
            int partition = 3;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            // var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);
            Console.WriteLine(result);
            Assert.False(result);

        }

        [Fact]
        public void EqualSumKSubset_DP_Test_3()
        {
            int[] num = { 2, 1, 5, 5, 6 };
            int partition = 3;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            // var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);
            Console.WriteLine(result);
            Assert.False(result);

        }

        [Fact]
        public void EqualSumKSubset_Test_4()
        {
            int[] num = { 2, 1, 4, 5, 6 };
            int partition = 3;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSetMyCode(num, partition);
            Console.WriteLine(result);
            Assert.True(result);
        }

        [Fact]
        public void EqualSumKSubset_DP_Test_4()
        {
            int[] num = { 2, 1, 4, 5, 6 };
            int partition = 3;
            EqualSumKSubset EqualSumSubset = new EqualSumKSubset();
            //var result = EqualSumSubset.CanPartitionByKSubSet_1(num, partition);
            var result = EqualSumSubset.CanPartitionByKSubSet_DynamicProgramming(num, partition);
            Console.WriteLine(result);
            Assert.True(result);
        }
    }
}
