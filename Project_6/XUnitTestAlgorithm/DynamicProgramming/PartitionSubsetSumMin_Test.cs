using Algorithm.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class PartitionSubsetSumMin_Test
    {
        [Fact]
        public void MinDifference_Test()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 1, 6, 11, 5 };
            int expectedResult = 1;

            PartitionSubsetSumMin partition = new PartitionSubsetSumMin();
            var acutalResult1 = partition.MinDifferentRec(array);
            Console.WriteLine(acutalResult1);
            Assert.Equal(expectedResult, acutalResult1);

            PartitionSubsetSumMin partition1 = new PartitionSubsetSumMin();
            var acutalResult = partition1.MinDifference(array);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifference_Test_2()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 3, 9, 7, 3 };
            //int[] array = { 3, 9, 7, 4 };
            int expectedResult = 2;
            PartitionSubsetSumMin partition = new PartitionSubsetSumMin();
            var acutalResult = partition.MinDifference(array);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifference_Test_3()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = {-36,36};
            //int[] array = { 3, 9, 7, 4 };
            int expectedResult = 0;
            PartitionSubsetSumMin partition = new PartitionSubsetSumMin();
            var acutalResult = partition.MinDifference(array);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifference_Test_4()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 76, 8, 45, 20, 74, 84, 28, 1 }; //Solution is not worknig for this array, leet code expected result = 2
            //int[] array = { 3, 9, 7, 4 };
            int expectedResult = 0;
            //Leet code is expected = 2
            PartitionSubsetSumMin partition = new PartitionSubsetSumMin();
            var acutalResult2 = partition.FindMinDistance(array);
            Console.WriteLine(acutalResult2);

            var acutalResult1 = partition.FindMin(array);
            Console.WriteLine(acutalResult1);
            var acutalResult = partition.MinDifference(array);
            Console.WriteLine(acutalResult);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifference_Test_5()
        {
            //int[] array = { 5, 10, 12, 13, 15, 18 };
            //int[] array = { 3,1,4,2,2,1 };
            int[] array = { 76, 8, 45, 20, 74, 84, 28, 1 }; //Solution is not worknig for this array, leet code expected result = 2
                                                            //int[] array = { 3, 9, 7, 4 };

            //Leet code is wrong for this use case, output should be 0.
            //Here is two sub module, which distance is 0;
            //{1,28,74,20,45}	=	168
            // {84, 8, 76} = 168


            int expectedResult = 2;
            //Leet code is expected = 2
            PartitionSubsetSumMin partition = new PartitionSubsetSumMin();
            var acutalResult1 = partition.MinDifferentRec(array);
            Console.WriteLine(acutalResult1);
            Assert.Equal(expectedResult, acutalResult1);

        }
    }
}
