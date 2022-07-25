using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    public static class Help
    {
        public static void Swap<T>(T[] elements, int first, int second)
        {
            T temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }
        public static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }
        public static bool IsSorted<T>(T[] elements) where T : IComparable
        {
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i - 1].CompareTo(elements[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Sort
    {
        public static Random random = new Random();

        public static void Shuffle<T>(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int r = i + random.Next(0, elements.Length - i);
                Help.Swap(elements, i, r);
            }
        }
        public static void Merge<T>(T[] elements) where T : IComparable
        {
            MergeAlgo(elements, 0, elements.Length);
        }

        // Merge Algorithm
        private static void MergeAlgo<T>(T[] elements, int left, int right) where T : IComparable
        {
            // Difference
            int diff = right - left;

            // Recursion Exit Clause
            if (diff <= 1) return;

            // Recurrsion
            int mid = left + diff / 2;
            MergeAlgo(elements, left, mid);
            MergeAlgo(elements, mid, right);

            // Post-Recurrsion
            T[] temp = new T[diff];
            int i = left, j = mid;
            for (int k = 0; k < diff; k++)
            {
                if (i == mid) temp[k] = elements[j++];
                else if (j == right) temp[k] = elements[i++];
                else if (Help.Less(elements[j], elements[i])) temp[k] = elements[j++];
                else temp[k] = elements[i++];
            }
            for (int k = 0; k < diff; k++)
            {
                elements[left + k] = temp[k];
            }
        }
    }
}
