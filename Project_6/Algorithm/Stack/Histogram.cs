using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class Histogram
    {
        // {6, 2, 5, 4, 5, 1, 6}
        public int GetMaximumArea(int[] heights)
        {

            int maxArea = 0;
            HeightKeyPair[] left = GetNearestSmallestToLeft(heights);
            HeightKeyPair[] right = GetNearestSmallestToRight(heights);

            for (int i=0; i< heights.Length; i++)
            {
                int width = right[i].Key - left[i].Key - 1;
                int area = heights[i] * width;
                if (area > maxArea)
                    maxArea = area;
            }
            return maxArea;
        }

        public HeightKeyPair[] GetNearestSmallestToLeft(int[] nums)
        {
            int sudoIndex = -1;
            int n = nums.Length - 1;
            HeightKeyPair[] result = new HeightKeyPair[nums.Length];
            Stack<HeightKeyPair> stack = new Stack<HeightKeyPair>();

            for (int i = 0; i <= n; i++)
            {
                while (stack.Count > 0 && nums[i] <= stack.Peek().Value)
                    stack.Pop();
                if (stack.Count > 0 && stack.Peek().Value < nums[i])
                    result[i] = stack.Peek();
                else
                    result[i] = new HeightKeyPair() { Key = sudoIndex, Value = sudoIndex } ;
                stack.Push(new HeightKeyPair() { Key=i, Value= nums[i] });
            }
            return result;
        }

        public HeightKeyPair[] GetNearestSmallestToRight(int[] nums)
        {
            int sudoIndex = nums.Length;
            int n = nums.Length - 1;
            HeightKeyPair[] result = new HeightKeyPair[nums.Length];
            Stack<HeightKeyPair> stack = new();

            for (int i = n; i >= 0; i--)
            {
                while (stack.Count > 0 && nums[i] <= stack.Peek().Value)
                    stack.Pop();
                if (stack.Count > 0 && stack.Peek().Value < nums[i])
                    result[i] = stack.Peek();
                else
                    result[i] = new HeightKeyPair() { Key = sudoIndex, Value = sudoIndex };
                stack.Push(new HeightKeyPair() { Key = i, Value = nums[i] });
            }
            return result;
        }
    }

    public struct HeightKeyPair
    {
        public int Key;
        public int Value;
    }
}
