namespace Algorithm.Heap
{
    public class MinimiseCostConnectRopes
    {
        /// <summary>
        /// This is question was asked amazon
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int GetMinCostUsedPriorityQueue(int[] arr,int n)
        {
            int totalCost = 0;
            PriorityQueue<int,int> priorityQueue = new();

            for(int i = 0; i < n; i++)
                priorityQueue.Enqueue(arr[i], arr[i]);

            do
            {
                int minRope1 = priorityQueue.Dequeue();
                int minRope2 = priorityQueue.Dequeue();
                int newRopeCost = minRope1 + minRope2;
                totalCost += newRopeCost;
                priorityQueue.Enqueue(newRopeCost, newRopeCost);

            } while(priorityQueue.Count > 1);

            return totalCost;
        }

        public int GetMinCostUseMinHeap(int[] arr, int n)
        {
            int totalCost = 0;
            MinHeap minHeap = new MinHeap(n);

            for (int i = 0; i < n; i++)
                minHeap.Add(arr[i]);

            do
            {
                int minRope1 = minHeap.Pop();
                int minRope2 = minHeap.Pop();
                int newRopeCost = minRope1 + minRope2;
                totalCost += newRopeCost;
                minHeap.Add(newRopeCost);

            } while (minHeap.GetSize() > 1);

            return totalCost;
        }
    }
}
