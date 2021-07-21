using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem is when you add a value type to ArrayList, since it
            // accepts a object, boxing will happen.
            var list = new ArrayList();
            list.Add(1);
            list.Add("string");
            list.Add(DateTime.Now);

            // You get the value as an Object, so if you want and Int, you'll
            // have to unbox it.
            var one = list[0];
            var oneInt = (int)list[0];

            // Instead use a Generic List
            var genericList = new List<int>();
        }
    }
}
