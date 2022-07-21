using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class MinHeapKeyPair<TPriority,TElement>
    {
        private readonly HeapKeyValue<TElement>[] _heapElements;
        private int _heapSize;
        IHeapCompare<TElement>? IHeapCompare = null;

        public MinHeapKeyPair(int size)
        {
            _heapElements = new HeapKeyValue<TElement>[size];
        }

        public MinHeapKeyPair(int size, IHeapCompare<TElement> comparer)
        {
            _heapElements = new HeapKeyValue<TElement>[size];
            IHeapCompare = comparer;
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < _heapSize;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < _heapSize;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private HeapKeyValue<TElement> GetLeftChild(int elementIndex) => _heapElements[GetLeftChildIndex(elementIndex)];
        private HeapKeyValue<TElement> GetRightChild(int elementIndex) => _heapElements[GetRightChildIndex(elementIndex)];
        private HeapKeyValue<TElement> GetParent(int elementIndex) => _heapElements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = _heapElements[firstIndex];
            _heapElements[firstIndex] = _heapElements[secondIndex];
            _heapElements[secondIndex] = temp;

        }

        public int GetSize()
        {
            return _heapSize;
        }

        public bool IsEmpty()
        {
            return _heapSize == 0;
        }

        public HeapKeyValue<TElement> Top()
        {
            if (_heapSize == 0)
                throw new IndexOutOfRangeException();

            return _heapElements[0];
        }

        public HeapKeyValue<TElement> Pop()
        {
            if (_heapSize == 0)
                throw new IndexOutOfRangeException();

            var result = _heapElements[0];
            _heapElements[0] = _heapElements[_heapSize - 1];
            _heapElements[_heapSize - 1] = new HeapKeyValue<TElement>();
            _heapSize--;

            if (IHeapCompare != null)
                HeapifyDownCompare();
            else 
                HeapifyDown();

            return result;
        }

        public void Add(HeapKeyValue<TElement> element)
        {
            if (_heapSize == _heapElements.Length)
                throw new IndexOutOfRangeException();
            element.IndexId = _heapSize;
            _heapElements[_heapSize] = element;
            _heapSize++;
            if (IHeapCompare != null)
                HeapifyUpCompare();
            else 
                HeapifyUp();
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).HeapKey < GetLeftChild(index).HeapKey)
                {
                    smallerIndex = GetRightChildIndex(index);
                }

               if (_heapElements[smallerIndex].HeapKey >= _heapElements[index].HeapKey)
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void HeapifyUp()
        {
            var index = _heapSize - 1;
            while (!IsRoot(index) && _heapElements[index].HeapKey < GetParent(index).HeapKey)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        /// <summary>
        /// This is needed for only Frequence example since it required to sort on second prority
        /// </summary>
        private void HeapifyDownCompare()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index)
                    //&& GetRightChild(index).HeapKey < GetLeftChild(index).HeapKey
                    && IHeapCompare != null && IHeapCompare.CompareData(GetRightChild(index), GetLeftChild(index))
                    )
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (_heapElements[smallerIndex].HeapKey >= _heapElements[index].HeapKey)
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        /// <summary>
        /// This is needed for only Frequence example since it required to sort on second prority
        /// </summary>
        private void HeapifyUpCompare()
        {
            var index = _heapSize - 1;
            while (!IsRoot(index) && IHeapCompare != null && IHeapCompare.CompareData(_heapElements[index], GetParent(index)))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        
    }
}
