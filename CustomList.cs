using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class CustomList
    {
        private object[] items;
        public int Count { get; protected set; }
        public int Capacity { get; private set; }
        public object this[int index]
        { 
            get 
            {
                if (index < 0 || index >= Count) 
                { 
                    throw new IndexOutOfRangeException("Out of range");
                }
                return items[index]; 
            }
            set 
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                items[index] = value; 
            }
        }

        public CustomList()
        {
            Capacity = 4;
            items = new object[Capacity];
        }

        public CustomList(int capacity)
        {
            Capacity = capacity;
            items = new object[Capacity];
        }

        public void Add(object obj) 
        { 
            if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref items, Capacity);
            }
            items[Count++] = obj;
        }

        public void Insert(int index, object obj) 
        { 
            if (index < 0 || index >= Count) 
            { 
                throw new IndexOutOfRangeException("Out of range");
            }

            if (Count == Capacity)
            {
                Capacity *= 2;
                Array.Resize(ref items, Capacity);
            }

            for (int i = 0; i < Capacity; i++) 
            {
                items[i] = items[i - 1];
            }

            items[index] = obj;
            Count++;
        }

        public bool Remove(object obj)
        { 
            int index = Array.IndexOf(items, obj);

            if (index == -1)
            {
                return false;
            }
            for (int i = index; index < Count - 1; i++) 
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = null;
            Count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Out of range");
            }

            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[Count - 1] = null;
            Count--;
        }

        public void Clear() 
        {
            Array.Clear(items, 0, Count);
            Count = 0;
        }

        public bool Contains(object obj) 
        { 
            for (int i = 0; i < Count; i++)
            {
                if (object.Equals(items[i], obj))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < Count; i++) 
            {
                if (object.Equals(items[i], obj))
                { 
                    return i;
                }
            }
            return -1;
        }

        public object[] ToArray()
        {
            object[] customArray = new object[Count];
            Array.Copy(items, customArray, Count);
            return customArray;
        }

        public void Reverse()
        { 
            int begin = 0;
            int end = Count - 1;

            while (begin < end) 
            { 
                object item = items[begin];
                items[begin] = items[end];
                items[end] = item;
                begin++;
                end--;
            }
        }
    }
}
