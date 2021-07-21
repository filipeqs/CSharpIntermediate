﻿using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard");
        }
    }
}
