using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.SortingAndSearching;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class BinarySearchExt_Test
    {
        [Fact]
        public void FirstAndLastoccurrence_Test1()
        {
            int[] nums = { 1, 3, 5, 5, 5, 5, 67, 123, 125 };
            int searchValue = 5;
            int expectedFirstElement = 2;
            int expectedLastElement = 5;
            BinarySearchExt binarySearch = new BinarySearchExt();
            var acutalFirstElement = binarySearch.BinarySearchFirstElement(nums, searchValue);
            var acutalLastElement = binarySearch.BinarySearchLastElement(nums, searchValue);
            Assert.Equal(expectedFirstElement, acutalFirstElement);
            Assert.Equal(expectedLastElement, acutalLastElement);
        }

        [Fact]
        public void CountElements_Test1()
        {
            int[] nums = { 1, 3, 5, 5, 5, 5, 67, 123, 125 };
            int searchValue = 5;
            int expectedCount = 4;
            BinarySearchExt binarySearch = new BinarySearchExt();
            var acutalCount = binarySearch.CountofElements(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }
    }
}
