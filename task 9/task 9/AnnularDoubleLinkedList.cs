using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class AnnularDoubleLinkedList<T>
    {
        T data;
        AnnularDoubleLinkedList<T> next;
        AnnularDoubleLinkedList<T> previous;
        public int Count 
        { 
            get
            {
                return SeachCount(this);
            } 
        }
        public AnnularDoubleLinkedList()
        {
            data = default;
            next = null;
            previous = null;
        }
        private AnnularDoubleLinkedList(T item)
        {
            data = item;
            next = null;
            previous = null;
        }
        public AnnularDoubleLinkedList<T> Add(T item)
        {
            AnnularDoubleLinkedList<T> begin = this;
            if (begin.Count == 0)
            {
                begin.data = item;
                begin.next = null;
                begin.previous = null;
            }
            else
            {
                if (begin.Count == 1)
                {
                    AnnularDoubleLinkedList<T> temp = new AnnularDoubleLinkedList<T>();
                    temp.data = item;
                    temp.previous = begin;
                    temp.next = begin;
                    begin.next = temp;
                    begin.previous = temp;
                }
                else
                {
                    AnnularDoubleLinkedList<T> temp = new AnnularDoubleLinkedList<T>(item);
                    temp.next = begin;
                    begin.previous = temp;
                    AnnularDoubleLinkedList<T> temp1 = begin;
                    for (int i = 1; i < begin.Count; i++)
                    {
                        temp1 = temp1.next;
                    }
                    temp1.next = temp;
                    temp.previous = temp1;
                }
            }
            return begin;
        }
        int SeachCount(AnnularDoubleLinkedList<T> begin)
        {
            int count = 0;
            AnnularDoubleLinkedList<T> temp = begin;
            if (temp.data.ToString() == "0") return 0;
            else 
            {
                do
                {
                    count++;
                    if (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    else
                    {
                        break;
                    }
                } while (temp != begin);
            }
            return count;
        }
        public IEnumerator<T> GetEnumerator()
        {
            AnnularDoubleLinkedList<T> current = this;
            for (int i = 0; i < this.Count; i++)
            {
                yield return current.data;
                current = current.next;

            }
        }
        public AnnularDoubleLinkedList<T> Remove(int index)
        {
            AnnularDoubleLinkedList<T> begin = this;
            AnnularDoubleLinkedList<T> temp = begin;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }
            AnnularDoubleLinkedList<T> temp1 = temp.next;
            AnnularDoubleLinkedList<T> temp2 = temp.previous;
            temp1.previous = temp2;
            temp2.next = temp1;
            return begin;
        }
        public static T Take(int index, AnnularDoubleLinkedList<T> collection)
        {
            AnnularDoubleLinkedList<T> begin = collection;
            AnnularDoubleLinkedList<T> temp = begin;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }
            return temp.data;
        }
        public int IndexOf(T item)
        {
            int index = -1;
            AnnularDoubleLinkedList<T> begin = this;
            AnnularDoubleLinkedList<T> temp = begin;
            for (int i = 1; i < begin.Count+1; i++)
            {
                if (item.ToString() == temp.data.ToString())
                {
                    index = i;
                    break;
                }
                temp = temp.next;
            }
            return index;
        }
        public static AnnularDoubleLinkedList<int> CreateCollection(int n)
        {
            AnnularDoubleLinkedList<int> collection = new AnnularDoubleLinkedList<int>();
            for (int i = 1; i <= n; i++)
            {
                collection.Add(i);
            }
            return collection;
        }
    }
}
