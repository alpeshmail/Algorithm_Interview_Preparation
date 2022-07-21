using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class MaxHeapKeyPair<TPriority,TElement> 
    {
        private readonly HeapKeyValue<TElement>[] _heapElements;
        private int _heapSize;

        public MaxHeapKeyPair(int size)
        {
            _heapElements = new HeapKeyValue<TElement>[size];
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

        public HeapKeyValue<TElement>[] GetAllElements()
        {
            return _heapElements;
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
            _heapElements[_heapSize - 1] = new HeapKeyValue<TElement>() { HeapKey = -1 };
            _heapSize--;

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

            HeapifyUp();
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index).HeapKey > GetLeftChild(index).HeapKey)
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_heapElements[biggerIndex].HeapKey < _heapElements[index].HeapKey)
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void HeapifyUp()
        {
            var index = _heapSize - 1;
            while (!IsRoot(index) && _heapElements[index].HeapKey > GetParent(index).HeapKey)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);

                //if (HasRightChild(parentIndex))
                //{
                //    int l = GetLeftChild(parentIndex);
                //    int r = GetRightChild(parentIndex);
                //    if (r > l)
                //        Swap(GetLeftChildIndex(parentIndex), GetRightChildIndex(parentIndex));
                //}
                index = parentIndex;
            }
        }


    }
}
