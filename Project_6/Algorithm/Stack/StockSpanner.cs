using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class StockSpanner
    {
        Stack<int> stack = new Stack<int>();
        public int[] GetSpanArray(int[] priceArray)
        {
            int[] spanArray = new int[priceArray.Length];
            for(int i=0;i< priceArray.Length; i++)
                spanArray[i] = Next(priceArray[i]);
            return spanArray;
        }

        public int Next(int price)
        {
            int count = 0;
            stack.Push(price);
            foreach(var stackItem in stack)
            {
                if (stackItem > price)
                    break;
                count++;
            }
            return count;
        }
    }
}
