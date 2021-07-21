using System;
using System.Collections.Generic;

namespace DesignAStack
{
    public class Stack
    {
        private readonly List<object> Items = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Value can not be null");

            Items.Add(obj);
        }

        public object Pop()
        {
            if (Items.Count == 0)
                throw new InvalidOperationException("There is no item in the list");

            var lastIndex = Items.Count - 1;

            var itemRemoved = Items[lastIndex];

            Items.RemoveAt(lastIndex);

            return itemRemoved;
        }

        public void Clrear()
        {
            Items.Clear();
        }
    }
}
