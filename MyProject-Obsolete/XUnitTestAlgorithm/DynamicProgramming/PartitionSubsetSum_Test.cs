using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class PartitionSubsetSum_Test
    {

        [Fact]
        public void GFG_FindPartiion()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 3, 1, 5, 9, 12 };
            bool expectedResult = true;
            PartitionSubsetSum partition = new PartitionSubsetSum();
            var acutalResult = partition.FindPartiion(array, array.Length);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void CanPartitionSubSet_Test1()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 3, 1, 5, 9, 12 };
            bool expectedResult = true;
            PartitionSubsetSum partition = new PartitionSubsetSum();
            var acutalResult = partition.CanPartition(array, 14);
            Assert.Equal(expectedResult, acutalResult);
        }


        [Fact]
        public void CanPartitionSubSet_Test2()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 3, 1, 5, 9, 12 };
            bool expectedResult = false;
            PartitionSubsetSum partition = new PartitionSubsetSum();
            var acutalResult = partition.CanPartition(array, 7);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void CanPartitionSubSet_Test3()
        {
            int[] array = { 5, 10, 12, 13, 15, 18 };
            bool expectedResult = true;
            PartitionSubsetSum partition = new PartitionSubsetSum();
            var acutalResult = partition.CanPartition(array, 30);
            Assert.Equal(expectedResult, acutalResult);
        }
    }
}
