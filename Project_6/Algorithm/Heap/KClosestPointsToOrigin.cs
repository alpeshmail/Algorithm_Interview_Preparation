using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Heap
{
    public class KClosestPointsToOrigin
    {

        public int[,] GetClosesPoints(int[,] twoDArray,int K)
        {
            //Length of array
            int n = twoDArray.GetLength(0);
            PriorityQueue<ClosestPointPair,int> priorityQueue = new(new IntMaxCompare()); //max heap

            for (int i=0; i< n; i++)
            {
                int X = twoDArray[i, 0];
                int Y = twoDArray[i, 1];
                int distance = (X * X) + (Y * Y);
                priorityQueue.Enqueue(new ClosestPointPair() { X = X, Y = Y }, distance);
                if (priorityQueue.Count > K)
                    priorityQueue.Dequeue();
            }

            int heapLength = priorityQueue.Count;
            int[,] result = new int[heapLength, 2];

            //Get data in asc order.
            for(int i = heapLength - 1; i >= 0; i--)
            {
                var queItem= priorityQueue.Dequeue();
                result[i, 0] = queItem.X;
                result[i, 1] = queItem.Y;
            }

            return result;
        }
    }

    public struct ClosestPointPair
    {
        public int X;
        public int Y;
    }


}
