using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    /// <summary>
    /// 0(1) Space complexity, since manage on single stack,not creating multiple stack.
    /// </summary>
    public class ExtendedStack 
    {
        private Stack<int> stack;
        private int minValue;
        private int maxValue;

        public ExtendedStack()
        {
            stack = new Stack<int>();
            minValue = -1;
            maxValue = -1;
        }

        public void Push(int elem)
        {
            if (stack.Count == 0)
            {
                minValue = elem;
                maxValue = elem;
                stack.Push(elem);
            }
            else if (elem < minValue)
            {
                int newValue = 2*elem - minValue;
                minValue = elem;
                stack.Push(newValue);
            }
            else if (elem > maxValue)
            {
                int newValue = elem + maxValue;
                maxValue = elem;
                stack.Push(newValue);
            }
            else 
            {
                stack.Push(elem);
            }
        }

        public int Pop()
        {
            int popValue = stack.Pop();
            if (stack.Count == 0)
            {
                minValue = -1;
                return popValue;
            }
            else if (popValue < minValue)
            {
                int currentMinValue = minValue;
                int newMinValue = 2 * minValue - popValue;
                minValue = newMinValue;
                return currentMinValue;
            }
            else if (popValue > maxValue )
            {
                int currentMaxValue = maxValue;
                int newMaxValue = popValue -  maxValue;
                maxValue = newMaxValue;
                return currentMaxValue;
            }

            return popValue;
        }

        public int Peek()
        {
            if (stack.Count == 0)
                return -1;
            return stack.Peek();
        }

        public int GetMinElement()
        {
            return minValue;
        }

        public int GetMaxElement()
        {
            return maxValue;
        }
    }
}
