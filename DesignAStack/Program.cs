using System;

namespace DesignAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();

                stack.Push(null);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
