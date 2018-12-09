using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OperatorOverloading.Task6
{
    struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int w, int h) : this()
        {
            this.Width = w;
            this.Height = h;
        }
        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[Width = {Width}; Height = {Height}]";
    }
}
