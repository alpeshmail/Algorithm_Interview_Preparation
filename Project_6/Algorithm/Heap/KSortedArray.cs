using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class KSortedArray
    {
        public int[] DoSort(int[] nums,int K)
        {
            MinHeap minHeap = new MinHeap(nums.Length);
            int iresetValue = 0;
            for(int i=0;i< nums.Length; i++)
            {
                minHeap.Add(nums[i]);
                if (minHeap.GetSize() > K)
                {
                    int popValue = minHeap.Pop();
                    nums[iresetValue] = popValue;
                    iresetValue++;
                }
            }

            int heapSize = minHeap.GetSize();
            for (int i=0;i < heapSize; i++)
            {
                int popValue = minHeap.Pop();
                nums[iresetValue] = popValue;
                iresetValue++;
            }

            return nums;
        }
        
    }
}
