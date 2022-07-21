using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class LargestElement
    {
        public int GetKthLargetElement(int[] nums,int K)
        {
            MinHeap minHeap = new MinHeap(nums.Length);
            for(int i=0; i< nums.Length;i++)
            {
                minHeap.Add(nums[i]);
                if (minHeap.GetSize() > K)
                    minHeap.Pop();
            }

            int result = minHeap.Top();
            return result;
        }

        public int[] GetKLargetElement(int[] nums, int K)
        {
            MinHeap minHeap = new MinHeap(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Add(nums[i]);
                if (minHeap.GetSize() > K)
                    minHeap.Pop();
            }

            var heapArray = minHeap.GetAllElements();
            Array.Resize(ref heapArray, K);
            return heapArray;
        }

    }
}
