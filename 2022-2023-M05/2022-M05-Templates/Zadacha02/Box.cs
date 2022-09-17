using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public class Box<T>
    {
        public int Count { get; private set; }

        private List<T> items;
        public Box()
        {
            this.items = new List<T>();
            this.Count = 0;
        }

        public void Add(T element)
        {
            this.items.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            T remove = this.items.Last();
            this.items.Remove(this.items.Last());
            this.Count--;
            return remove;
        }

        public override string ToString()
        {
            string temp = null;
            string type = null;
            foreach (var item in items)
            {
                type = item.GetType().ToString();
                temp += item.ToString();
            }
            return $"{type}: {temp}";
        }
    }
}
