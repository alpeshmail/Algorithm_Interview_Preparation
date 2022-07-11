using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class PartitionSubsetSum_Rec_Test
    {
        [Fact]
        public void PartitionSubsetSum()
        {
            int[] array = { 5,10,12,13,15,18 };
            bool expectedResult = true;
            PartitionSubsetSum_Rec partition = new PartitionSubsetSum_Rec();
            var acutalResult = partition.FindSubset(array,30);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PartitionSubsetSum_1()
        {
            int[] array = { 1, 6, 11, 5 };
            bool expectedResult = true;
            PartitionSubsetSum_Rec partition = new PartitionSubsetSum_Rec();
            var acutalResult = partition.FindSubset(array);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PartitionSubsetSum_2()
        {
            int[] array = { 1, 6, 11, 5 };
            bool expectedResult = true;
            var acutalResult = GFG_Rec.findMin(array);
            Console.WriteLine(acutalResult);
            //Assert.Equal(expectedResult, acutalResult);
        }

    }
}
