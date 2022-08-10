using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Stack
{
    public class RainWaterTrapping
    {
        public int GetWaterTrapping(int[] height)
        {
            int[] left = new int[height.Length];
            int[] right = new int[height.Length];

            int totalWater = 0;
            left[0]= height[0];
            right[height.Length - 1] = height[^1]; //heights.Length - 1

            //Fill Right array
            for (int i = height.Length - 2; i >= 0; i--)
                right[i] = Math.Max(right[i + 1], height[i]);

            for (int i = 0;i < height.Length; i++){
                if (i == 0)
                    left[i] = height[i];
                else 
                    left[i] = Math.Max(left[i-1], height[i]);
                int watertrap = Math.Min(left[i], right[i]) - height[i];
                totalWater += watertrap;
            }

            return totalWater;

        }
    }
}
