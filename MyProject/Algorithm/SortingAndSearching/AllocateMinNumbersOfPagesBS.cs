using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.SortingAndSearching
{
    public class AllocateMinNumbersOfPagesBS
    {
        public int GetMinNumberofPages(int[] pages, int numberofStudents)
        {
            int sum = 0;
            int maxNumber = pages[0];
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i] > maxNumber)
                    maxNumber = pages[i];
                sum += pages[i];
            }

            int start = maxNumber;
            int end = sum;
            int result = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (IsValid(mid,pages,numberofStudents))
                {
                    result = mid;
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }

            return result;
        }

        public bool IsValid(int currentMin, int[] pages, int numberofStudents)
        {
            int istudentRequired = 1;
            int sum = 0;
            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i] > currentMin)
                    return false;
                
                if (sum + pages[i] > currentMin)
                {
                    istudentRequired++;
                    sum = pages[i];
                    if (istudentRequired > numberofStudents)
                        return false;
                }
                else
                    sum += pages[i];
            }
            return true;
        }


    }
}
