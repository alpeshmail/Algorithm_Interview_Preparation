using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class KClosestNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public int[] GetElementsExcludeKey(int[] arr,int K,int X)
        {
            MaxHeapKeyPair<int, int> maxHeapKeyPair = new(arr.Length);

            for(int i=0;i< arr.Length; i++)
            {
                int heapKey = Math.Abs(X - arr[i]);
                if (heapKey != 0) // Use condition if we don't want to include X number
                    maxHeapKeyPair.Add(new HeapKeyValue<int>() { HeapKey = heapKey, HeapValue = arr[i] });
                if (maxHeapKeyPair.GetSize() > K)
                    maxHeapKeyPair.Pop();
            }

            var heapArray= maxHeapKeyPair.GetAllElements();
            int[] result = new int[K];
            for(int i=0; i < K;i++)
                result[i] = heapArray[i].HeapValue;
            return result;
        }

        /// <summary>
        /// /// GetElements and GetElementsPriorityQueue is give you same output but two differnet code, one created own heap and second one used microsoft priority queue
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public int[] GetElements(int[] arr, int K, int X)
        {
            MaxHeapKeyPair<int, int> maxHeapKeyPair = new(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                int heapKey = Math.Abs(X - arr[i]);
                maxHeapKeyPair.Add(new HeapKeyValue<int>() { HeapKey = heapKey, HeapValue = arr[i] });
                if (maxHeapKeyPair.GetSize() > K)
                    maxHeapKeyPair.Pop();
            }

            //Get Array in sorted order so doing pop one by one so get max value of heap
            var count = maxHeapKeyPair.GetSize();
            int[] result = new int[K];
            for (int i = count - 1; i >= 0; i--)
            {
                var iHeapValue = maxHeapKeyPair.Pop(); ;
                result[i] = iHeapValue.HeapValue;
            }
            return result;

            //var heapArray = maxHeapKeyPair.GetAllElements();
            //int[] result = new int[K];
            //for (int i = 0; i < K; i++)
            //    result[i] = heapArray[i].HeapValue;
            //return result;
        }

        /// <summary>
        /// /// GetElements and GetElementsPriorityQueue is give you same output but two differnet code, one created own heap and second one used microsoft priority queue
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public int[] GetElementsPriorityQueue(int[] arr, int K, int X)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(new IntMaxCompare()); //max heap
            //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(); // min heap

            for (int i = 0; i < arr.Length; i++)
            {
                int heapKey = Math.Abs(X - arr[i]);
                priorityQueue.Enqueue (arr[i], heapKey);
                if (priorityQueue.Count > K)
                    priorityQueue.Dequeue();
            }
            //Get Array in sorted order so doing pop one by one so get max value of heap
            var queueCount = priorityQueue.Count;
            int[] result = new int[K];
            for (int i = 0; i < queueCount; i++)
            {
                int iValue= priorityQueue.Dequeue();
                result[i] = iValue;
            }
            return result;
        }
    }
}
