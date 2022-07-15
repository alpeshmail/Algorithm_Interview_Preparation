using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.SortingAndSearching.Sorting;
using Xunit;

namespace XUnitTestAlgorithm.SortingAndSearching.Sorting
{
    public class SortingAlgo_Test
    {
        [Fact]
        public void BubbleSort_Test1()
        {
            int[] nums =  { 5, 1, 4, 2, 8 };
            int[] expectedResult = {  1, 2, 4, 5, 8 };
            SortingAlgo sortingAlgo = new SortingAlgo();
            var acutalResult = sortingAlgo.BubbleSort(nums);
            for(int i=0; i < expectedResult.Length -1; i++)
            {
                Assert.Equal(expectedResult[i], acutalResult[i]);
            }
        }

        [Fact]
        public void InsertionSort_Test1()
        {
            int[] nums = { 5, 1, 4, 2, 8 };
            int[] expectedResult = { 1, 2, 4, 5, 8 };
            SortingAlgo sortingAlgo = new SortingAlgo();
            var acutalResult = sortingAlgo.InsertionSort(nums);
            for (int i = 0; i < expectedResult.Length - 1; i++)
            {
                Assert.Equal(expectedResult[i], acutalResult[i]);
            }
        }

        [Fact]
        public void InsertionSort_Test2()
        {
            int[] nums = { 12, 11, 13, 5, 6 };
            int[] expectedResult = { 5 , 6 , 11 , 12 , 13 };
            SortingAlgo sortingAlgo = new SortingAlgo();
            var acutalResult = sortingAlgo.InsertionSort(nums);
            for (int i = 0; i < expectedResult.Length - 1; i++)
            {
                Assert.Equal(expectedResult[i], acutalResult[i]);
            }
        }

        [Fact]
        public void MergeSort_Test1()
        {
            int[] nums = { 12, 11, 13, 5, 6, 7 };
            int[] expectedResult = { 5, 6, 7, 11, 12, 13 };
            SortingAlgo sortingAlgo = new SortingAlgo();
            var acutalResult = sortingAlgo.MergeSort(nums);
            for (int i = 0; i < expectedResult.Length - 1; i++)
            {
                Assert.Equal(expectedResult[i], acutalResult[i]);
            }
        }

        [Fact]
        public void QuickSort_Test1()
        {
            int[] nums = { 4, 2, 8, 3, 1, 5, 7, 11, 6 };
            int[] expectedResult = { 1,2 ,3, 4, 5, 6, 7, 8, 11 };
            SortingAlgo sortingAlgo = new SortingAlgo();
            var acutalResult = sortingAlgo.QuickSort(nums);
            for (int i = 0; i < expectedResult.Length - 1; i++)
            {
                Assert.Equal(expectedResult[i], acutalResult[i]);
            }
        }

        //{4, 2, 8, 3, 1, 5, 7,11,6}
    }
}
