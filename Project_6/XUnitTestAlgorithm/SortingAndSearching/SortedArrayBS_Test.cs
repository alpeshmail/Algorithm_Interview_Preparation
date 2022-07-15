using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.SortingAndSearching;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class SortedArrayBS_Test
    {
        [Fact]
        public void FindFloor_Test1()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 5;
            int expectedResult = 2;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindFloor(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindFloor_Test2()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 20;
            int expectedResult = 19;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindFloor(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindFloor_Test3()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 0;
            int expectedResult = -1;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindFloor(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindCeil_Test1()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 5;
            int expectedResult = 8;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindCeil(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }
        [Fact]
        public void FindCeil_Test2()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 20;
            int expectedResult = -1;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindCeil(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void FindCeil_Test3()
        {
            int[] nums = { 1, 2, 8, 10, 10, 12, 19 };
            int searchValue = 0;
            int expectedResult = 1;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindCeil(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test1()
        {
            char[] letters = { 'D', 'J', 'K' };
            char searchValue = 'B';
            int expectedResult = 'D';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test2()
        {
            char[] letters = { 'D', 'J', 'K' };
            char searchValue = 'K';
            int expectedResult = 'D';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test3()
        {
            char[] letters = { 'D', 'J', 'K' };
            char searchValue = 'J';
            int expectedResult = 'K';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test4()
        {
            char[] letters = { 'D', 'J', 'K' };
            char searchValue = 'D';
            int expectedResult = 'J';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test5()
        {
            char[] letters = { 'D', 'J', 'K' };
            char searchValue = 'I';
            int expectedResult = 'J';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void NextAlpahbet_Test6()
        {
            char[] letters = { 'a', 'b' };
            char searchValue = 'z';
            int expectedResult = 'a';
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindNextAlphabet(letters, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void InfiniteArray_Test1()
        {
            int[] nums = {3, 5, 7, 9, 10, 90, 100, 130, 140, 160, 170};
            int searchValue = 10;
            int expectedResult = 4;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindElementInfiniteArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinaryInfiniteArray_Test1()
        {
            int[] nums = { 0, 0, 0, 0, 0, 0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }; 
            int searchValue = 1;
            int expectedResult = 11;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindFirstElementInFiniteArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void BinaryInfiniteArray_Test2()
        {
            int[] nums = { 0, 0, 0, 0,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int searchValue = 1;
            int expectedResult = 4;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.FindFirstElementInFiniteArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test1()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 6;
            int expectedResult = 5;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test2()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 5;
            int expectedResult = 5;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test3()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 8;
            int expectedResult = 10;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test4()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 11;
            int expectedResult = 10;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test5()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 20;
            int expectedResult = 15;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void MinDifferenceInSortedArray_Test6()
        {
            int[] nums = { 2, 5, 10, 12, 15 };
            int searchValue = 1;
            int expectedResult = 2;
            SortedArrayBS sortedArrayBS = new SortedArrayBS();
            var acutalResult = sortedArrayBS.MinDifferenceInSortedArray(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }
    }
}
