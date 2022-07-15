using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.SortingAndSearching;
using Xunit;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class BinarySearch_Test
    {
        [Fact]
        public void BinarySearchTest1()
        {
            int[] nums = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            int searchValue = 110;
            int expectedResult = 6;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult= binarySearch.BinarySearchAsc(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearchTest2()
        {
            int[] nums = { 2, 3, 4, 10, 40 };
            int searchValue = 10;
            int expectedResult = 3;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchAsc(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearchTest3()
        {
            int[] nums = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            int searchValue = 110;
            int expectedResult = 6;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchAscRec(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearchTest4()
        {
            int[] nums = { 2, 3, 4, 10, 40 };
            int searchValue = 10;
            int expectedResult = 3;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchAscRec(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_Decending_Test1()
        {
            int[] nums = { 5, 4, 3, 2, 1 };
            int searchValue = 4;
            int expectedResult = 1;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchDecending(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_Decending_Test2()
        {
            int[] nums = { 10, 8, 2, -9 };
            int searchValue = 5;
            int expectedResult = -1;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchDecending(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_Decending_Test3()
        {
            
            int[] nums = { 5, 4, 3, 2, 1 };
            int searchValue = 5;
            int expectedResult = 0;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchDecending(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_NotKnow_Test1()
        {
            int[] nums = { 10, 8, 2, -9 };
            int searchValue = 5;
            int expectedResult = -1;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchNotKnow(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_NotKnow_Test2()
        {

            int[] nums = { 5, 4, 3, 2, 1 };
            int searchValue = 5;
            int expectedResult = 0;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchNotKnow(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }
        [Fact]
        public void BinarySearch_NotKnow_Test3()
        {
            int[] nums = { 10, 20, 30, 50, 60, 80, 110, 130, 140, 170 };
            int searchValue = 110;
            int expectedResult = 6;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchNotKnow(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinarySearch_NotKnow_Test4()
        {
            int[] nums = { 2, 3, 4, 10, 40 };
            int searchValue = 10;
            int expectedResult = 3;
            BinarySearch binarySearch = new BinarySearch();
            var acutalResult = binarySearch.BinarySearchNotKnow(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }


    }
}
