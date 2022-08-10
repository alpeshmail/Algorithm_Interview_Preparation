using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SortingAndSearching
{
    /*
     // The idea of formula is to return higher value of pos
    // when element to be searched is closer to arr[hi]. And
    // smaller value when closer to arr[lo]

    pos = lo + [ \frac{(x-arr[lo])*(hi-lo) }{ (arr[hi]-arr[Lo]) }]

    arr[] ==> Array where elements need to be searched
    x     ==> Element to be searched
    lo    ==> Starting index in arr[]
    hi    ==> Ending index in arr[]
     */
    /// <summary>
    /// The Interpolation Search is an improvement over Binary Search for instances, 
    /// where the values in a sorted array are uniformly distributed. 
    /// </summary>
    public class InterpolationSearch
    {
        //we can archive this using recursive programing as well
        public int Search(int[] nums, int X)
        {
            return Search(nums, 0, nums.Length - 1, X);
        }

        /// <summary>
        /// { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 }
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <param name="X"></param>
    /// <returns></returns>
    public int Search(int[] nums,int low,int high,int X)
        {
            int result = -1;

            while (low <= high && X >= nums[low] && X <= nums[high])
            {
                int pos = low
                 + (((high - low) / (nums[high] - nums[low]))
                    * (X - nums[low]));

                //0 + ((14 - 0) / (43 - 10) * (18 - 10);

                if (nums[pos] == X)
                {
                    result = pos;
                    break;
                }
                else if (nums[pos] > X)
                {
                    high = pos - 1;
                }
                else
                {
                    low = pos + 1;
                }
            }
            return result;
        }

    }
}
