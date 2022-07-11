using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithm.DynamicProgramming
{
    /// <summary>
    /// Equal sum partition by K Subset or partition by 2 subsets.
    /// if partitino by 2 subsets, means sum/2
    /// </summary>
    public class EqualSumKSubset
    {
        public bool[] UsedArray = null;
        public List<int[]> lstResult = new List<int[]>();


        /// <summary>
        /// My code, work for all cases
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public bool CanPartitionByKSubSetMyCode(int[] nums, int K)
        {
            
            int length = nums.Length;
            UsedArray = new bool[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];
            if (sum % K != 0)
                return false;
            int targetValue = sum / K;
            int[] sumofSubset = new int[K];
            bool[] takenSubset = new bool[nums.Length];

            Array.Sort(nums);
            var startIndex = length - 1;
            UsedArray[startIndex] = true;
            sumofSubset[0] = nums[startIndex];
            
            takenSubset[startIndex] = true;
            var acutalResult = CanPartitionByKSubSetRecMyCode(nums, 0, length, K, targetValue, sumofSubset, length - 2, takenSubset);
         
            return acutalResult;
        }

        private bool CanPartitionByKSubSetRecMyCode(int[] nums, int currentIndex,int length, int K, int targetValue, int[] sumofSubset,int limitIndex, bool[] takenSubset)
        {
            if (targetValue == sumofSubset[currentIndex])
            {
                List<int> newlstSubsetCollection = new List<int>();
                for (int j = 0; j < takenSubset.Length; j++)
                {
                    if (takenSubset[j])
                    {
                        newlstSubsetCollection.Add(nums[j]);
                        UsedArray[j] = takenSubset[j];
                        takenSubset[j] = false;
                    }
                }
                lstResult.Add(newlstSubsetCollection.ToArray());
                if (currentIndex == K - 1)
                   return true;
                
                var actualResult = CanPartitionByKSubSetRecMyCode(nums, currentIndex+1, length, K, targetValue, sumofSubset, length - 1, takenSubset);
                return actualResult;
            }

            for(int i=limitIndex;i>= 0; i--)
            {
                if (UsedArray[i])
                    continue;
                if (sumofSubset[currentIndex] + nums[i] > targetValue)
                    continue;
                else
                {
                    sumofSubset[currentIndex] += nums[i];
                    takenSubset[i] = true;
                    var subResult = CanPartitionByKSubSetRecMyCode(nums, currentIndex, length, K, targetValue, sumofSubset, i - 1, takenSubset);
                    if (!subResult)
                    {
                        sumofSubset[currentIndex] -= nums[i];
                        takenSubset[i] = false;
                    }
                    else
                        return subResult;
                }
            }

            return false;
        }

        /// <summary>
        /// Created code base on some online version but not working for some condition.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="totalSubsets"></param>
        /// <returns></returns>
        public bool CanPartitionByKSubSet(int[] num,int totalSubsets)
        {
            UsedArray = new bool[num.Length];
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
                sum += num[i];
            if (sum % totalSubsets != 0)
                return false;
            int targetValue = sum / totalSubsets;
            var acutalResult = CanPartitionByKSubSetRec(num,0 , totalSubsets, targetValue, 0);
            return acutalResult;
        }

        /// <summary>
        /// Created code base on some online version but not working for some condition.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="index"></param>
        /// <param name="countSubsets"></param>
        /// <param name="targetValue"></param>
        /// <param name="sumofSubset"></param>
        /// <returns></returns>
        private bool CanPartitionByKSubSetRec(int[] num,int index, int countSubsets,int targetValue,int sumofSubset)
        {
            if (countSubsets == 0)
                return true;
            if (sumofSubset == targetValue)
            {
              return  CanPartitionByKSubSetRec(num, 0, countSubsets - 1, targetValue, 0);
            }

            //List<int> lstsubset = new List<int>();

            for (int j = index; j < num.Length; j++)
            {
                if (sumofSubset + num[j] > targetValue && UsedArray[j])
                    continue;
                UsedArray[j] = true;
                var result = CanPartitionByKSubSetRec(num, j + 1,countSubsets, targetValue, sumofSubset + num[j]);
                if (result)
                    return true;
                UsedArray[j] = false;
            }
            return false;
        }

        /// <summary>
        /// DP programmming, more optimize with matrix
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CanPartitionByKSubSet_DynamicProgramming(int[] nums, int k)
        {
            int length = nums.Length;
            bool[] AlreadyUsedArray = new bool[length];
            int sum = 0;
            for (int i = 0; i < length; i++)
                sum += nums[i];
            if (sum % k != 0)
                return false;
            int targetValue = sum / k;
            int foundSubsets = 0;
            bool isFound = false;

            Array.Sort(nums);
            for(int i= length-1; i >= 0; i--)
            {
                if (AlreadyUsedArray[i])
                    continue;
                if (foundSubsets == k)
                    return true;
                //int[,] sumofSubset = new int[length + 1, length + 1];
                int sumofSubset = nums[i];
              

                if (sumofSubset == targetValue)
                {
                    bool[] taken = new bool[length];
                    taken[i] = true;
                    foundSubsets = ProcessSubSetFound(nums, length, foundSubsets, taken, AlreadyUsedArray);
                    continue;
                }

                for (int j = i - 1; j >= 0; j--)
                {
                    if (AlreadyUsedArray[i] || sumofSubset + nums[j] > targetValue)
                        continue;
                    isFound = ProcessSubValues(nums, length, AlreadyUsedArray, targetValue, ref foundSubsets, i, ref sumofSubset,  j);
                    if (isFound)
                        break;
                    sumofSubset = nums[i];
                }

                if (foundSubsets == k)
                {
                    isFound = true;
                    break;
                }
            }


            return isFound;
        }

        private bool ProcessSubValues(int[] nums, int length, bool[] AlreadyUsedArray, int targetValue, ref int foundSubsets, int currentIndex, ref int sumofSubset, int nextIndex)
        {
            bool isFound = false;
            bool[] taken = new bool[length];
            taken[currentIndex] = true;
            for (int ik = nextIndex; ik >= 0; ik--)
            {
                if (AlreadyUsedArray[ik] || sumofSubset + nums[ik] > targetValue)
                    continue;
                taken[ik] = true;
                sumofSubset += nums[ik];
                if (sumofSubset == targetValue)
                {
                    isFound = true;
                    foundSubsets = ProcessSubSetFound(nums, length, foundSubsets, taken, AlreadyUsedArray);
                    break;
                }
                else if (sumofSubset > targetValue)
                {
                    break;
                }
            }
            return isFound;
        }

        private int ProcessSubSetFound(int[] nums, int length, int foundSubsets, bool[] taken, bool[] AlreadyUsedArray)
        {
            foundSubsets++;
            List<int> lstSubSet = new List<int>();
            for (int ij = 0; ij < length; ij++)
            {
                if (taken[ij])
                {
                    AlreadyUsedArray[ij] = taken[ij];
                    lstSubSet.Add(nums[ij]);
                }
            }

            lstResult.Add(lstSubSet.ToArray());
            return foundSubsets;
        }

        /// <summary>
        /// Try to create dynamic programming but this version is not working well.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CanPartitionByKSubSet_1(int[] nums, int k)
        {
            int length = nums.Length;
            bool[] AlreadyUsedArray = new bool[length];
            int sum = 0;
            for (int i = 0; i < length; i++)
                sum += nums[i];
            if (sum % k != 0)
                return false;
            int targetValue = sum / k;
            int sumofSubset = 0;
            int foundsubset = 0;
            bool IsFound = false;

            var sortedNum = nums.OrderByDescending(x => x).ToArray();

            //Array.Sort(num);

            for (int i=0;i< length; i++)
            {
                if (AlreadyUsedArray[i])
                    continue;
                IsFound = false;
                List<int> usedCollection = new List<int>();
                sumofSubset = sortedNum[i];
                if (sumofSubset == targetValue)
                {
                    foundsubset++;
                    AlreadyUsedArray[i] = true;
                    usedCollection.Add(sortedNum[i]);
                    lstResult.Add(usedCollection.ToArray());
                    IsFound = true;
                    continue;
                }
                usedCollection.Add(i);

                for (int j = 0; j < length; j++)
                //for (int j = length; j == 0; j--)
                {
                    if (i == j || AlreadyUsedArray[i] || AlreadyUsedArray[j])
                        continue;
                    if (sumofSubset + sortedNum[j] > targetValue)
                        continue;
                    sumofSubset += sortedNum[j];
                    usedCollection.Add(j);
                    if (sumofSubset == targetValue)
                    {
                        foundsubset++;
                        IsFound = true;
                        List<int> resultSubset = ResetArray(sortedNum, usedCollection, AlreadyUsedArray);
                        lstResult.Add(resultSubset.ToArray());
                        break;
                    }
                }

                if (IsFound == false)
                    break;
            }
            if (!IsFound) return false;
            if (foundsubset == k)
                return true;

            return false;
        }

        private List<int> ResetArray(int[] sortedNum, List<int> usedCollection,bool[] AlreadyUsedArray)
        {
            List<int> resultSubset = new List<int>();
            for (int i = 0; i < usedCollection.Count; i++)
            {
                int iIndexItem = usedCollection[i];
                resultSubset.Add(sortedNum[iIndexItem]);
                AlreadyUsedArray[iIndexItem] = true;
            }

            return resultSubset;
        }
    }

    // C# program to check whether an array can be
// partitioned into K subsets of equal sum

    public class GFG_EqualSumKSubset
    {

        // Recursive Utility method to check K equal sum
        // subsetition of array
        /**
            array	 - given input array
            subsetSum array - sum to store each subset of the array
            taken	 - boolean array to check whether element
                            is taken into sum partition or not
            K		 - number of partitions needed
            N		 - total number of element in array
            curIdx	 - current subsetSum index
            limitIdx	 - lastIdx from where array element should
                            be taken */
        private bool isKPartitionPossibleRec(int[] arr, int[] subsetSum, bool[] taken,
                        int subset, int K, int N, int curIdx, int limitIdx)
        {
            if (subsetSum[curIdx] == subset)
            {
                Console.WriteLine(curIdx);
                /* current index (K - 2) represents (K - 1) subsets of equal
                    sum last partition will already remain with sum 'subset'*/
                if (curIdx == K - 2) // I belive it should be K-1
                    return true;

                // recursive call for next subsetition
                return isKPartitionPossibleRec(arr, subsetSum, taken, subset,
                                                    K, N, curIdx + 1, N - 1);
            }

            // start from limitIdx and include elements into current partition
            for (int i = limitIdx; i >= 0; i--)
            {
                // if already taken, continue
                if (taken[i])
                    continue;
                int tmp = subsetSum[curIdx] + arr[i];

                // if temp is less than subset then only include the element
                // and call recursively
                if (tmp <= subset)
                {
                    // mark the element and include into current partition sum
                    taken[i] = true;
                    subsetSum[curIdx] += arr[i];
                    bool nxt = isKPartitionPossibleRec(arr, subsetSum, taken,
                                                    subset, K, N, curIdx, i - 1);

                    // after recursive call unmark the element and remove from
                    // subsetition sum
                    taken[i] = false;
                    subsetSum[curIdx] -= arr[i];
                    if (nxt)
                        return true;
                }
            }
            return false;
        }

        // Method returns true if arr can be partitioned into K subsets
        // with equal sum
        public bool isKPartitionPossible(int[] arr, int N, int K)
        {
            // If K is 1, then complete array will be our answer
            if (K == 1)
                return true;

            // If total number of partitions are more than N, then
            // division is not possible
            if (N < K)
                return false;

            // if array sum is not divisible by K then we can't divide
            // array into K partitions
            int sum = 0;
            for (int i = 0; i < N; i++)
                sum += arr[i];
            if (sum % K != 0)
                return false;

            // the sum of each subset should be subset (= sum / K)
            int subset = sum / K;
            int[] subsetSum = new int[K];
            bool[] taken = new bool[N];

            // Initialize sum of each subset from 0
            for (int i = 0; i < K; i++)
                subsetSum[i] = 0;

            // mark all elements as not taken
            for (int i = 0; i < N; i++)
                taken[i] = false;

            // initialize first subset sum as last element of
            // array and mark that as taken
            subsetSum[0] = arr[N - 1];
            taken[N - 1] = true;

            // call recursive method to check K-substitution condition
            return isKPartitionPossibleRec(arr, subsetSum, taken,
                                            subset, K, N, 0, N - 1);
        }

        //// Driver code
        //static public void Main()
        //{

        //    int[] arr = { 2, 1, 4, 5, 3, 3 };
        //    int N = arr.Length;
        //    int K = 3;

        //    if (isKPartitionPossible(arr, N, K))
        //        Console.WriteLine("Partitions into equal sum is possible.");
        //    else
        //        Console.WriteLine("Partitions into equal sum is not possible.");
        //}
    }

    // This code is contributed by ajit.

}
