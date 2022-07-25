using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    public class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }

        private const int InitialCapacity = 16;
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.Count = 0;
            this.elements = new T[capacity];
        }
        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }
            var item = this.elements[this.Count - 1];
            this.Count--;
            if (this.Count <= this.elements.Length / 2 && this.Count >= InitialCapacity)
            {
                this.Shrink();
            }
            return item;
        }

        private void Shrink()
        {
            var newElements = new T[this.elements.Length / 2];
            for (int i = 0; i < this.elements.Length / 2; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        public T[] ToArray()
        {
            return this.elements.ToArray();
        }
        private void Grow()
        {
            var newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

    }
}
