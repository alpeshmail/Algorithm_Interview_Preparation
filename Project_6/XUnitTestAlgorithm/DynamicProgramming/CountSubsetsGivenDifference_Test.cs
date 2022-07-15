using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Algorithm.DynamicProgramming;

namespace XUnitTestAlgorithm.DynamicProgramming
{
    public class CountSubsetsGivenDifference_Test
    {
        [Fact]
        public void CountSubsetsGivenDifference_Test1()
        {
            int[] array = { 1, 1, 2, 3 };
            int difference = 1;
            int expectedValue = 3;
            CountSubsetsGivenDifference CountSubsetsGivenDifference = new CountSubsetsGivenDifference();
            var acutalResult = CountSubsetsGivenDifference.GetCountSubsetsRecursive(array, difference);

            Assert.Equal(expectedValue, acutalResult);

        }

        [Fact]
        public void CountSubsetsGivenDifference_Test2()
        {
            int[] array = { 1, 1, 2, 3 };
            int difference = 1;
            int expectedValue = 3;
            CountSubsetsGivenDifference CountSubsetsGivenDifference = new CountSubsetsGivenDifference();
            var acutalResult = CountSubsetsGivenDifference.GetCountSubsetsDynamically(array, difference);

            Assert.Equal(expectedValue, acutalResult);

        }

        [Fact]
        public void CountSubsetsGivenDifference_Test3()
        {
            int[] array = { 3,1,2,3 };
            int difference = 3;
            int expectedValue = 3;
            CountSubsetsGivenDifference CountSubsetsGivenDifference = new CountSubsetsGivenDifference();
            var acutalResult = CountSubsetsGivenDifference.GetCountSubsetsRecursive(array, difference);

            Assert.Equal(expectedValue, acutalResult);

        }

        [Fact]
        public void CountSubsetsGivenDifference_Test4()
        {
            int[] array = { 3, 1, 2, 3 };
            int difference = 3;
            int expectedValue = 3;
            CountSubsetsGivenDifference CountSubsetsGivenDifference = new CountSubsetsGivenDifference();
            var acutalResult = CountSubsetsGivenDifference.GetCountSubsetsDynamically(array, difference);

            Assert.Equal(expectedValue, acutalResult);

        }

    }
}
