using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    /// <summary>
    /// https://leetcode.com/problems/daily-temperatures/
    /// </summary>
    public class DailyTemperatures
    {
        /// <summary>
        /// Given an array of integers temperatures represents the daily temperatures, 
        /// return an array answer such that answer[i] is the number of days you have to wait after the ith day 
        /// to get a warmer temperature. If there is no future day for which this is possible, 
        /// keep answer[i] == 0 instead.
        /// Example 1:
        ///Input: temperatures = [73,74,75,71,69,72,76,73]
        ///Output: [1,1,4,2,1,1,0,0]
        ///Example 2:
        ///Input: temperatures = [30,40,50,60]
        ///Output: [1,1,1,0]
        /// </summary>
        /// <param name="temperatures"></param>
        /// <returns></returns>
        //Similar problem for stack, will implement later
        public int[] GetTempDifference(int[] temperatures)
        {
            Stack<int> stack = new Stack<int>();
            int n = temperatures.Length - 1;
            int[] result = new int[temperatures.Length];

            for(int i = n;i >= 0;i--)
            {
                int count = 0;
                bool IsFound = false;
                if (stack.Count > 0)
                {
                    foreach(var stackItem in stack)
                    {
                        count++;
                        if (stackItem > temperatures[i])
                        {
                            IsFound = true;
                            break;
                        }    
                    }
                    if (!IsFound)
                        count = 0;
                }
                stack.Push(temperatures[i]);
                result[i] = count;
            }

            return result;
        }
    }
}
