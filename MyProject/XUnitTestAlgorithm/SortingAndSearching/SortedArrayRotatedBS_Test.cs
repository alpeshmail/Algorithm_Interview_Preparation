using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.SortingAndSearching;

namespace XUnitTestAlgorithm.SortingAndSearching
{
    public class SortedArrayRotatedBS_Test
    {
        [Fact]
        public void FirstAndLastoccurrence_Test1()
        {
            int[] nums = { 15, 18, 2, 3, 6, 12 };
            int expectedResult = 2;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.NumberOfTimesArrayRoated(nums);

            Assert.Equal(expectedResult, acutalElement);

        }

        [Fact]
        public void FirstAndLastoccurrence_Test2()
        {
            int[] nums = { 7, 9, 11, 12, 5 };
            int expectedResult = 4;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.NumberOfTimesArrayRoated(nums);

            Assert.Equal(expectedResult, acutalElement);

        }

        [Fact]
        public void FirstAndLastoccurrence_Test3()
        {
            int[] nums = { 7, 9, 11, 12, 15 };
            int expectedResult = 0;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.NumberOfTimesArrayRoated(nums);

            Assert.Equal(expectedResult, acutalElement);

        }


        [Fact]
        public void FindElements_Test1()
        {
            int[] nums = { 30, 40, 50, 10, 20 };
            int expectedResult = 3;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.FindElement(nums,10);
            Assert.Equal(expectedResult, acutalElement);

        }

        [Fact]
        public void FindElements_Test2()
        {
            int[] nums = { 30, 40, 50, 5, 10, 20 };
            int expectedResult = 4;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.FindElement(nums, 10);
            Assert.Equal(expectedResult, acutalElement);

        }

        [Fact]
        public void FindElements_Test3()
        {
            int[] nums = { 30, 40, 50, 5, 10, 20 };
            int expectedResult = 1;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.FindElement(nums, 40);
            Assert.Equal(expectedResult, acutalElement);

        }

        [Fact]
        public void FindElements_Test4()
        {
            int[] nums = { 30, 40, 50, 5, 10, 20 };
            int expectedResult = 5;
            SortedArrayRotatedBS binarySearch = new SortedArrayRotatedBS();
            var acutalElement = binarySearch.FindElement(nums, 20);
            Assert.Equal(expectedResult, acutalElement);

        }
    }
 }
