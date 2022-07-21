using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    /// <summary>
    /// For descending sort 
    /// </summary>
    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int X, int Y) => Y.CompareTo(X);
    }

    public struct HeapKeyValue<TElement>
    {
        public int HeapKey;
        public TElement? HeapValue;
        /// <summary>
        /// Original Indexing number, not change when swaping data for tree, May used this for multiple sort order depending on use case
        /// </summary>
        public int IndexId;
    }

    /// <summary>
    /// For Mutliple sort comapre for Heap
    /// </summary>
    /// <typeparam name="TElement"></typeparam>
    public interface IHeapCompare<TElement>
    {
        bool CompareData(HeapKeyValue<TElement> heapKeyValue1, HeapKeyValue<TElement> heapKeyValue2);
    }

    /// <summary>
    ///  For Mutliple sort comapre for Heap frequency
    /// </summary>
    public class KFrequenceCompare : IHeapCompare<int>
    {
        public bool CompareData(HeapKeyValue<int> heapKeyValue1, HeapKeyValue<int> heapKeyValue2)
        {
            if (heapKeyValue1.HeapKey == heapKeyValue2.HeapKey)
                return (heapKeyValue1.HeapValue < heapKeyValue2.HeapValue);

            return (heapKeyValue1.HeapKey < heapKeyValue2.HeapKey);
        }
    }

    public struct PriorityQueueItem
    {
        public int Key;
        public int Value;
        public int IndexId;
    }

    /// <summary>
    /// Ascending sort compare with multiple sort order, Used in priority queue
    /// </summary>
    public class MinHeapCompare : IComparer<PriorityQueueItem>
    {
        public int Compare(PriorityQueueItem X, PriorityQueueItem Y)
        {
            if (X.Key == Y.Key)
                return X.Value.CompareTo(Y.Value);

            return X.Key.CompareTo(Y.Key);
        }
    }

    /// <summary>
    /// Ascending sort compare with multiple sort order, Used in priority queue
    /// </summary>
    public class MaxHeapCompare : IComparer<PriorityQueueItem>
    {
        public int Compare(PriorityQueueItem X, PriorityQueueItem Y)
        {
            if (X.Key == Y.Key)
                return Y.Value.CompareTo(X.Value);

            return Y.Key.CompareTo(X.Key);
        }
    }
}
