using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can not instanciate abstract class
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();
            circle.Copy();
        }
    }
}
