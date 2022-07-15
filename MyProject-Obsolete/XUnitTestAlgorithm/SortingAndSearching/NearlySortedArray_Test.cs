using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.SortingAndSearching;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class NearlySortedArray_Test
    {
        [Fact]
        public void NearlySortedArray_Test1()
        {
            int[] nums = { 10, 3, 40, 20, 50, 80, 70 };
            int searchValue = 40;
            int expectedCount = 2;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }

        [Fact]
        public void NearlySortedArray_Test2()
        {
            int[] nums = { 10, 3, 40, 20, 50, 80, 70 };
            int searchValue = 90;
            int expectedCount = -1;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }

        [Fact]
        public void NearlySortedArray_Test3()
        {
            int[] nums =  {3, 2, 10, 4, 40};
            int searchValue = 4;
            int expectedCount = 3;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }

        [Fact]
        public void NearlySortedArray_Test4()
        {
            int[] nums = { 15, 20, 30, 25, 35};
            int searchValue = 25;
            int expectedCount = 3;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }

        [Fact]
        public void NearlySortedArray_Test5()
        {
            int[] nums = { 15, 20, 30, 25, 35 };
            int searchValue = 35;
            int expectedCount = 4;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }

        [Fact]
        public void NearlySortedArray_Test6()
        {
            int[] nums = { 15, 20, 30, 25, 35 };
            int searchValue = 100;
            int expectedCount = -1;
            NearlySortedArray nearlySortedArray = new NearlySortedArray();
            var acutalCount = nearlySortedArray.FindElement(nums, searchValue);
            Assert.Equal(expectedCount, acutalCount);
        }
      
    }
}
