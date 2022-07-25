using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i].CompareTo(key) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
