using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class KFrequence
    {
        /// <summary>
        /// /// GetElements and GetElementsPriorityQueue is give you same output but two differnet code, one created own heap and second one used microsoft priority queue
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int[] GetElements(int[] arr, int K)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]] = map[arr[i]] + 1;
                else
                    map[arr[i]] = 1;
            }

            /// Note - KFrequenceCompare are require for multiple Heap key and value sort order
            MinHeapKeyPair<int, int> minHeapKeyPair = new(map.Count, new KFrequenceCompare());
            foreach (var pair in map)
            {
                minHeapKeyPair.Add(new HeapKeyValue<int>() { HeapKey = pair.Value, HeapValue = pair.Key });
                if (minHeapKeyPair.GetSize() > K)
                    minHeapKeyPair.Pop();
            }


            //Get Array in sorted order so doing pop one by one so get max value of heap
            var count = minHeapKeyPair.GetSize();
            int[] result = new int[K];
            for (int i = count - 1; i >= 0; i--)
            {
                var iHeapValue = minHeapKeyPair.Pop(); ;
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
        /// GetElements and GetElementsPriorityQueue is give you same output but two differnet code, one created own heap and second one used microsoft priority queue
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int[] GetElementsPriorityQueue(int[] arr, int K)
        {
            Dictionary<int, int> map = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]] = map[arr[i]] + 1;
                else
                    map[arr[i]] = 1;
            }


            //Note - PriorityQueue is required a compare interface implement for decending order and mutliple sort.
            //it work with single aceding sort without parsing an interface.
            //IntMaxCompare -- decending order sort for max heap.
            //MinHeapCompare -- multiple sort order in acending order. for decending order use MaxHeapCompare

            //PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(new IntMaxCompare()); //  Max Heap
            PriorityQueue<int, PriorityQueueItem> priorityQueue = new(new MinHeapCompare()); // min heap

            foreach (var pair in map)
            {
                priorityQueue.Enqueue(pair.Key, new PriorityQueueItem() { Key = pair.Value, Value = pair.Key });
                if (priorityQueue.Count > K)
                    priorityQueue.Dequeue();
            }


            //Get Array in sorted order so doing pop one by one so get max value of heap
            var queueCount = priorityQueue.Count;
            int[] result = new int[K];
            for (int i = 0; i < queueCount; i++)
            {
                int iValue = priorityQueue.Dequeue();
                result[i] = iValue;
            }
            return result;
        }
        public int[] GetSortArray(int[] arr)
        {

            Dictionary<int, int> map = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]] = map[arr[i]] + 1;
                else
                    map[arr[i]] = 1;
            }

            PriorityQueue<PriorityQueueItem, PriorityQueueItem> priorityQueue = new(new MaxSortHeapCompare()); // min heap
            int index = 0;
            foreach (var pair in map)
            {
                var item = new PriorityQueueItem() { Key = pair.Value, Value = pair.Key,IndexId = index };
                priorityQueue.Enqueue(item, item);
                index++;
            }

            var queueCount = priorityQueue.Count;
            int iCount = 0;
            for (int i = 0; i < queueCount; i++)
            {
                var itemRetun = priorityQueue.Dequeue();
                for (int j = 0; j < itemRetun.Key; j++)
                {
                    arr[iCount] = itemRetun.Value;
                    iCount++;
                }
            }
            return arr;
        }
    }

    public class MaxSortHeapCompare : IComparer<PriorityQueueItem>
    {
        //Sort Desc but if key match then asc
        public int Compare(PriorityQueueItem X, PriorityQueueItem Y)
        {
            //Second priority on value
            //if (X.Key == Y.Key)
            //    return X.Value.CompareTo(Y.Value);
            //Second priority on Index Id
            if (X.Key == Y.Key)
                return X.IndexId.CompareTo(Y.IndexId);

            return Y.Key.CompareTo(X.Key);
        }
    }

}
