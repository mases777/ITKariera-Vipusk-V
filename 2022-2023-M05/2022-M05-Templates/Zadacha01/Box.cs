using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Box<T>
    {
        private List<T> data;

        public int Count => this.data.Count;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove()
        {
            var remove = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return remove;
        }
    }
}
