using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    public class Search
    {
        public static int InterpolationSearch(int[] sortedArray, int key)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                int mid = low + ((key - sortedArray[low]) * (high - low))
                  / (sortedArray[high] - sortedArray[low]);
                if (sortedArray[mid] < key)
                    low = mid + 1;
                else if (sortedArray[mid] > key)
                    high = mid - 1;
                else
                    return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }
    }
}
