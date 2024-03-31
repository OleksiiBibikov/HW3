using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class CustomLinkedList : CustomList
    {
        public CustomLinkedList() : base() { }

        public Node First { get; protected set; } 
        public Node Last { get; protected set; }

        public void AddFirst(object obj) 
        {
            Node node = new Node(obj);
            node.Next = First;
            First = node;
            if (Last == null) 
            {
                Last = First;
            }
            Count++;
        }

        protected void AddLast(object obj) 
        { 
            Node node = new Node(obj);

            if (Last == null)
            {
                First = node;
            }
            else 
            { 
                Last.Next = node;
            }
            Last = node;
            Count++;
        }

        public void Add(object obj) 
        { 
            AddLast(obj);
        }

        public void Insert(int index, object obj) 
        { 
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Out of range");
            }
            if (index == 0)
            {
                AddFirst(obj);
            }
            else 
            { 
                Node indexAt = First;
                for (int i = 0; i < index - 1; i++) 
                { 
                    indexAt = indexAt.Next;
                }
                Node node = new Node(obj);
                node.Next = indexAt.Next;
                indexAt.Next = node;
                Count++;
            }
        }

        public new void Clear()
        { 
            base.Clear();
        }

        public bool Contains(object obj)
        {
            return base.Contains(obj);
        }

        public new object[] ToArray() 
        { 
            return base.ToArray(); 
        }
    }
}
