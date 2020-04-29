using System;
using System.Collections.Generic;
using System.Text;

namespace MyListGeneric
{
    class MyClassGeneric <T>
    {
        public T Data { get; set; }
        public MyClassGeneric <T> Next { get; set; }
        public MyClassGeneric (T data)
        {
            Data = data;
        }
    }
}
