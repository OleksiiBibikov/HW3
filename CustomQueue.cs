using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class CustomQueue : DoublyLinkedList
    {
        public int Count => base.Count;

        public void Enqueue(object obj)
        {
            AddLast(obj);
        }

        public object Dequeue()
        {
            object data = First.Data;
            RemoveFirst();
            return data;
        }

        public new void Clear() 
        { 
            base.Clear(); 
        }

        public bool Contains(object obj)
        { 
            return base.Contains(obj); 
        }

        public object Peek()
        {
            return First.Data;
        }

        public object[] ToArray()
        { 
            return base.ToArray(); 
        }
    }
}
