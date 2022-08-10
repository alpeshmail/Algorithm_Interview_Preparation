using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class NearestGreater
    {
        public int[] GetNearestGreaterToRight(int[] nums)
        {
            int n = nums.Length - 1;
            int[] result= new int[nums.Length];
            Stack<int> stack= new();

            for (int i = n; i >= 0; i--)
            {
                while (stack.Count > 0 && nums[i] > stack.Peek())
                    stack.Pop();
                if (stack.Count > 0 && stack.Peek() > nums[i])
                    result[i] = stack.Peek();
                else 
                    result[i] = -1;
                stack.Push(nums[i]);
            }
            return result;
        }

        public int[] GetNearestGreaterToLeft(int[] nums)
        {
            int n = nums.Length - 1;
            int[] result = new int[nums.Length];
            Stack<int> stack = new();

            for (int i = 0; i <= n; i++)
            {
                while (stack.Count > 0 && nums[i] > stack.Peek())
                    stack.Pop();
                if (stack.Count > 0 && stack.Peek() > nums[i])
                    result[i] = stack.Peek();
                else
                    result[i] = -1;
                stack.Push(nums[i]);
            }
            return result;
        }


    }
}
