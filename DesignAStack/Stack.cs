using System;
using System.Collections;

namespace DesignAStack
{
    public class Stack
    {
        private readonly ArrayList Items = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Value can not be null");

            Items.Add(obj);
        }

        public object Pop()
        {
            var lastIndex = Items.Count - 1;

            var itemRemoved = Items[lastIndex];
            Items.RemoveAt(lastIndex);

            return itemRemoved;
        }

        public void Clrea()
        {
            Items.Clear();
        }
    }
}
