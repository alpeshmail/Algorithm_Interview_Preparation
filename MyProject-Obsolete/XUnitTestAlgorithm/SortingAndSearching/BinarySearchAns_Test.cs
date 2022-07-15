using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.SortingAndSearching;
using Xunit;


namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class BinarySearchAns_Test
    {
        [Fact]
        public void PeackElement_Test1()
        {
            int[] nums = { 5, 10, 20, 15 };
            int expectedResult = 20;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PeackElement_Test2()
        {
            int[] nums = { 10, 20, 15, 2, 23, 90, 67 };
            int expectedResult = 20;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PeackElement_Test3()
        {
            int[] nums = { 10, 20, 30, 40, 50 };
            int expectedResult = 50;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PeackElement_Test4()
        {
            int[] nums = { 100, 80, 60, 50, 20 };
            int expectedResult = 100;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PeackElement_Test5()
        {
            int[] nums = { 1, 2, 3, 1 };
            int expectedResult = 3;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void PeackElement_Test6()
        {
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
            int expectedResult = 6;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.PeakElement(nums);
            Assert.Equal(expectedResult, acutalResult);
        }
        /// <summary>
        /// https://www.geeksforgeeks.org/find-the-maximum-element-in-an-array-which-is-first-increasing-and-then-decreasing/
        /// BitonicArray array same as peak elements, since it is increasing and then decreasing order.
        /// </summary>
        [Fact]
        public void MaxElementOfBitonicArray_Test1()
        {
            int[] nums = { 8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1 };
            int expectedResult = 500;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MaxElementOfBitonicArray_Test2()
        {
            int[] nums = { 1, 3, 50, 10, 9, 7, 6 };
            int expectedResult = 50;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MaxElementOfBitonicArray_Test3()
        {
            int[] nums = { 10, 20, 30, 40, 50 };
            int expectedResult = 50;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MaxElementOfBitonicArray_Test4()
        {
            int[] nums = { 120, 100, 80, 20, 0 };
            int expectedResult = 120;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MaxElementOfBitonicArray_Test5()
        {
            int[] nums = { 1, 30, 40, 50, 60, 70, 23, 20 };
            int expectedResult = 70;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MaxElementOfBitonicArray_Test6()
        {
            int[] nums = { 1, 3, 50, 10, 9, 7, 6 };
            int expectedResult = 50;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.MaximumElemeentInBitonicArray(nums);
            Assert.Equal(expectedResult, acutalResult);
        }


        [Fact]
        public void FindElementInBitonicArray_Test1()
        {
            int[] nums = { -3, 9, 18, 20, 17, 5, 1 };
            int keyValue = 20;
            int expectedResult = 3;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.FindElementInBitonicArray(nums, keyValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindElementInBitonicArray_Test2()
        {
            int[] nums = { -3, 9, 18, 20, 17, 5, 1 };
            int keyValue = 5;
            int expectedResult = 5;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.FindElementInBitonicArray(nums, keyValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindElementInBitonicArray_Test3()
        {
            int[] nums = { -3, 9, 18, 20, 17, 5, 1 };
            int keyValue = 1;
            int expectedResult = 6;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.FindElementInBitonicArray(nums, keyValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindElementInBitonicArray_Test4()
        {
            int[] nums = { -3, 9, 18, 20, 17, 5, 1 };
            int keyValue = -3;
            int expectedResult = 0;
            BinarySearchAns binarySearch = new BinarySearchAns();
            var acutalResult = binarySearch.FindElementInBitonicArray(nums, keyValue);
            Assert.Equal(expectedResult, acutalResult);
        }
    }
}
