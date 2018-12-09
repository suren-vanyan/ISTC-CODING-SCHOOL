using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OperatorOverloading.Task6
{
    struct Point
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public Point(int XCoord, int YCoord)
        {
            this.XCoord = XCoord;
            this.YCoord = YCoord;
        }

        public static Point operator +(Point p1, Point p2) { return new Point(p1.XCoord + p2.XCoord, p1.YCoord + p2.YCoord); }
        public static Point operator +(Point p1, int change) { return new Point(p1.XCoord + change, p1.YCoord + change); }


        public static Point operator -(Point p1, Point p2) { return new Point(p1.YCoord - p2.XCoord, p1.YCoord - p2.YCoord); }
        public static Point operator -(Point p1, int change) { return new Point(p1.YCoord - change, p1.YCoord - change); }


        public static Point operator ++(Point p) { return new Point(p.XCoord+1 , ++p.YCoord); }//need prefix increment or +1
        public static Point operator --(Point p) { return new Point(--p.XCoord, --p.YCoord); }//need prefix increment or -1


        public override string ToString() { return $"[{this.XCoord},{this.YCoord}]"; }

    }
}
