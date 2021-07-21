using System.Collections.Generic;

namespace MethodOverriding
{
    public static class Canvas
    {
        public static void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
                shape.Draw();
        }
    }
}
