using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Heap
{
    public class KthSmallestElement
    {

        /// <summary>
        /// Using Max Heap
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int GetElement(int[] nums, int K)
        {
            MaxHeap maxHeap = new MaxHeap(nums.Length);
            for(int i=0; i < nums.Length; i++)
            {
                maxHeap.Add(nums[i]);
                if (maxHeap.GetSize() > K)
                    maxHeap.Pop();

            }
            int result = maxHeap.Top();
            return result;

        }

        /// <summary>
        /// Using Microsoft SortedList
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int GetElementUsedSortedList(int[] nums, int K)
        {
            SortedList<int,int> lstSorted = new();

            for (int i = 0; i < nums.Length; i++)
            {
                lstSorted.Add(nums[i], nums[i]);
                if (lstSorted.Count > K)
                    lstSorted.RemoveAt(lstSorted.Count - 1);
            }

            int result = lstSorted.Last().Value;
            
            return result;

        }

        /// <summary>
        /// Using PriorityQueue SortedList
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int GetElementUsedPriorityQueue(int[] nums, int K)
        {
            PriorityQueue<int, int> priorityQueue = new (new IntMaxCompare());

            for (int i = 0; i < nums.Length; i++)
            {
                priorityQueue.Enqueue(nums[i], nums[i]);
                if (priorityQueue.Count > K)
                    priorityQueue.Dequeue();
            }

            int result = priorityQueue.Peek();

            return result;

        }

    }
}
