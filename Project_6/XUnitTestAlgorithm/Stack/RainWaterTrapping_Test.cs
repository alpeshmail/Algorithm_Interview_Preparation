using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithm.Stack;

namespace XUnitTestAlgorithm.Stack
{
    public class RainWaterTrapping_Test
    {
        [Fact]
        public void RainWaterTrapping_Test1()
        {
            //https://www.geeksforgeeks.org/trapping-rain-water/
            int[] heights = { 3, 0, 2, 0, 4 };
            int expectedResult = 7;
            RainWaterTrapping rainWaterTrapping = new RainWaterTrapping();
            var actualResult = rainWaterTrapping.GetWaterTrapping(heights);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void RainWaterTrapping_Test2()
        {
            //https://www.geeksforgeeks.org/trapping-rain-water/
            int[] heights = { 2, 0, 2 };
            int expectedResult = 2;
            RainWaterTrapping rainWaterTrapping = new RainWaterTrapping();
            var actualResult = rainWaterTrapping.GetWaterTrapping(heights);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void RainWaterTrapping_Test3()
        {
            //https://www.geeksforgeeks.org/trapping-rain-water/
            //https://leetcode.com/problems/trapping-rain-water/
            int[] heights = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int expectedResult = 6;
            RainWaterTrapping rainWaterTrapping = new RainWaterTrapping();
            var actualResult = rainWaterTrapping.GetWaterTrapping(heights);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void RainWaterTrapping_Test4()
        {
            //https://leetcode.com/problems/trapping-rain-water/
            int[] heights = { 4, 2, 0, 3, 2, 5 };
            int expectedResult = 9;
            RainWaterTrapping rainWaterTrapping = new RainWaterTrapping();
            var actualResult = rainWaterTrapping.GetWaterTrapping(heights);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
