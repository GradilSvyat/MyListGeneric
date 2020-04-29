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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
