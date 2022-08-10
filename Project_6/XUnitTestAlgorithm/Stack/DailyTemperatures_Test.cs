using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;

namespace XUnitTestAlgorithm.Stack
{
    public class DailyTemperatures_Test
    {
        [Fact]
        public void DailyTemperatures_Test1()
        {
            //https://leetcode.com/problems/daily-temperatures/
            int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] expectedResult = { 1, 1, 4, 2, 1, 1, 0, 0 };
            DailyTemperatures dailyTemp = new();
            var result = dailyTemp.GetTempDifference(temperatures);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void DailyTemperatures_Test2()
        {
            //https://leetcode.com/problems/daily-temperatures/
            int[] temperatures = { 30, 40, 50, 60 };
            int[] expectedResult = { 1, 1, 1, 0 };
            DailyTemperatures dailyTemp = new();
            var result = dailyTemp.GetTempDifference(temperatures);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void DailyTemperatures_Test3()
        {
            //https://leetcode.com/problems/daily-temperatures/
            int[] temperatures = { 30, 60, 90 };
            int[] expectedResult = { 1, 1, 0 };
            DailyTemperatures dailyTemp = new();
            var result = dailyTemp.GetTempDifference(temperatures);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
