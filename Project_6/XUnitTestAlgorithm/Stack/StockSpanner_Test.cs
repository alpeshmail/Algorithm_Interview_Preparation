using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm.Stack;
using Xunit;

namespace XUnitTestAlgorithm.Stack
{
    public class StockSpanner_Test
    {
        [Fact]
        public void StockSpanner_Test1()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.geeksforgeeks.org/the-stock-span-problem/
            //https://leetcode.com/problems/online-stock-span/
            int[] nums = { 100, 80, 60, 70, 60, 75, 85 };
            int[] expectedResult = { 1, 1, 1, 2, 1, 4, 6 };
            StockSpanner stockSpanner = new StockSpanner();
            var result = stockSpanner.GetSpanArray(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void StockSpanner_Test2()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.interviewbit.com/blog/stock-span-problem/
            int[] nums = { 100, 60, 70, 65, 80, 85 };
            int[] expectedResult = { 1, 1, 2, 1, 4, 5 };
            StockSpanner stockSpanner = new StockSpanner();
            var result = stockSpanner.GetSpanArray(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void StockSpanner_Test3()
        {
            //Next Grreater Element and NearestGreater To Right are same
            //https://www.interviewbit.com/blog/stock-span-problem/
            int[] nums = { 31, 27, 14, 21, 30, 22};
            int[] expectedResult = { 1, 1, 1, 2, 4, 1 };
            StockSpanner stockSpanner = new StockSpanner();
            var result = stockSpanner.GetSpanArray(nums);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
