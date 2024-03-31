using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class DoublyLinkedList : CustomLinkedList
    {
        public new int Count => base.Count;

        public void Add(object obj)
        {
            AddLast(obj);
        }

        public void AddFirst(object obj) 
        { 
            base.AddFirst(obj);
        }

        public void Remove(object obj)
        {
            base.Remove(obj);
        }

        public void RemoveFirst()
        {
            if (First != null)
            {
                base.Remove(Last.Data);
            }
        }
        public void RemoveLast() 
        { 
            if (Last != null) 
            {
                base.Remove(Last.Data);
            } 
        }

        public bool Contains(object obj) 
        { 
            return base.Contains(obj);
        }

        public object[] ToArray() 
        { 
            return base.ToArray(); 
        }

        public new void Clear() 
        { 
            base.Clear(); 
        }
    }
}
