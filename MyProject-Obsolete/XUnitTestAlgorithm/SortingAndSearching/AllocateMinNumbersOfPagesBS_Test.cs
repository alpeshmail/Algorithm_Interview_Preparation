using System;
using System.Collections.Generic;
using System.Text;
using Algorithm.SortingAndSearching;
using Xunit;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class AllocateMinNumbersOfPagesBS_Test
    {
        [Fact]
        public void AllocateMinNumbersOfPagesBS_Test1()
        {
            int[] nums = { 10, 20, 30, 40 };
            int searchValue = 2;
            int expectedResult = 60;
            AllocateMinNumbersOfPagesBS binarySearch = new AllocateMinNumbersOfPagesBS();
            var acutalResult = binarySearch.GetMinNumberofPages(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }

        [Fact]
        public void AllocateMinNumbersOfPagesBS_Test2()
        {
            ///https://www.geeksforgeeks.org/allocate-minimum-number-pages/
            int[] nums = { 12, 34, 67, 90 };
            int searchValue = 2;
            int expectedResult = 113;
            AllocateMinNumbersOfPagesBS binarySearch = new AllocateMinNumbersOfPagesBS();
            var acutalResult = binarySearch.GetMinNumberofPages(nums, searchValue);
            Assert.Equal(expectedResult, acutalResult);
        }
    }
}
