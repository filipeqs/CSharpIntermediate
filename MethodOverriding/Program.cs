using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Width = 100, Height = 100});
            shapes.Add(new Rectangle() { Width = 100, Height = 100 });

            Canvas.DrawShapes(shapes);
        }
    }
}
