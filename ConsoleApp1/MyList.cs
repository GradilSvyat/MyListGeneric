using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyListGeneric
{
    class MyList<T> : IEnumerable<T>
    {
        MyClassGeneric<T> head;
        MyClassGeneric<T> tail;
        int count;
        public void Add (T data)
        {
            MyClassGeneric<T> elementMyClass = new MyClassGeneric<T>(data);
            if (head == null)
                head = elementMyClass;
            else
                tail.Next = elementMyClass;
            
            tail = elementMyClass;

            count++;
        }
        public bool Remove (T data)
        {
            MyClassGeneric<T> current = head;
            MyClassGeneric<T> previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            MyClassGeneric<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
