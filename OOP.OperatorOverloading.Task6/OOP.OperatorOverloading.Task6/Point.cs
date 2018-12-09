using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.OperatorOverloading.Task6
{
    struct Point : IComparable<Point>
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


        public static Point operator ++(Point p) { return new Point(p.XCoord + 1, ++p.YCoord); }//need prefix increment or +1
        public static Point operator --(Point p) { return new Point(--p.XCoord, --p.YCoord); }//need prefix increment or -1



        // public static bool operator ==(Point p1, Point p2) { return p1.XCoord == p2.XCoord && p1.YCoord == p2.YCoord; }

        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);

        public static bool operator <(Point p1, Point p2) => (p1.CompareTo(p2) < 0);
        public static bool operator >(Point p1, Point p2) => (p1.CompareTo(p2) > 0);

        public static bool operator >=(Point p1, Point p2) => (p1.CompareTo(p2) >= 0);
        public static bool operator <=(Point p1, Point p2) => (p1.CompareTo(p2) <= 0);

        public override bool Equals(object o) { return o.ToString() == this.ToString(); }
        public override int GetHashCode() { return this.ToString().GetHashCode(); }


        public int CompareTo(Point other)
        {
            if (this.XCoord > other.XCoord && this.YCoord > other.YCoord)
                return 1;
            if (this.XCoord < other.XCoord && this.YCoord < other.YCoord)
                return -1;
            else
                return 0;
        }
    }
}
