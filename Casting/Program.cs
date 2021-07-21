using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamReader reader = new StreamReader(new MemoryStream());
            var list = new List<Shape>();
            list.Add(new Shape());
            list.Add(new Text());
        }

        static void useDownCasting()
        {
            Shape shape = new Text();
            Text text = (Text)shape;
        }

        static void useUpCasting()
        {
            // StreamReader reader = new StreamReader(new MemoryStream());

            var text = new Text();
            Shape shape = text;

            var list = new List<Shape>();
            list.Add(new Shape());
            list.Add(new Text());
        }
    }
}
