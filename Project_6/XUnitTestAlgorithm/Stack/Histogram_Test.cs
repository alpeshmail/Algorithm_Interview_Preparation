using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;


namespace XUnitTestAlgorithm.Stack
{
    public class Histogram_Test
    {
        [Fact]
        public void Histogram_Test1()
        {
            //https://www.geeksforgeeks.org/largest-rectangle-under-histogram/
            int[] nums = { 6, 2, 5, 4, 5, 1, 6 };
            int expectedResult = 12;
            Histogram histogram = new Histogram();
            var result = histogram.GetMaximumArea(nums);
            Assert.Equal(expectedResult, result);
            
        }

        [Fact]
        public void Histogram_Test2()
        {
            //https://leetcode.com/problems/largest-rectangle-in-histogram/
            int[] nums = { 2, 1, 5, 6, 2, 3 };
            int expectedResult = 10;
            Histogram histogram = new Histogram();
            var result = histogram.GetMaximumArea(nums);
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void Histogram_Test3()
        {
            //https://leetcode.com/problems/largest-rectangle-in-histogram/
            int[] nums = { 2, 4 };
            int expectedResult = 4;
            Histogram histogram = new Histogram();
            var result = histogram.GetMaximumArea(nums);
            Assert.Equal(expectedResult, result);

        }
    }
}
