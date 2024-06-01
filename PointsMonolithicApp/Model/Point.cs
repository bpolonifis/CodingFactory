using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsMonolithicApp.Model
{
    internal class Point : IEquatable<Point>, IComparable<Point>
    {
        public int X { get; set; }
        private static readonly IList<Point> _points = new List<Point>();
        public static IList<Point> Points { get { return new List<Point>(_points); } }

        public bool Equals(Point? other)
        {
            if (other is null) return false;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(Point? other)
        {
            return X -other!.X;
            //idia diadikasia me to parakatw
            //if (X > other!.X)
            //{
            //    return 1;
            //}
            //else if (X < other!.X)
            //{ 
            //    return -1; 
            //}

            //else
            //{
            //    return 0;
            //}
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj.GetType() != GetType()) return false;

            return CompareTo((Point)obj) == 0;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        public override string? ToString()
        {
            return $"x={X}";
        }

        public static bool operator >(Point? p1, Point? p2)
        { 
            if (p1 is null || p2 is null) return false;
            return p1.X > p2.X;
        }
        public static bool operator <(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X < p2.X;
        }
        public static bool operator >=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X >= p2.X;
        }
        public static bool operator <=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X <= p2.X;
        }
        public static bool operator ==(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X == p2.X;
        }
        public static bool operator !=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X != p2.X;
        }

        /*
         * CRUD API fot List<>
         * to work GetPointPosition(), needs Equals as above
         */
        public void Insert()
        {
            _points.Add(this);
        }
        public bool Update(Point? point)
        {
            int positionToUpdate = GetPointPosition();
            if (positionToUpdate ==-1 ) return false;
            _points[positionToUpdate] = point!;
            return true;
        }

        public Point? Delete()
        {
            int positionToDelete = GetPointPosition();
            if(positionToDelete ==-1 ) return null;
            Point? pointToReturn = _points[positionToDelete];
            _points.Remove(this);
            return pointToReturn;
        }

        public Point? GetPointOrNull()
        {
            return _points.Contains(this) ? _points[GetPointPosition()] : null;
        }



        private int GetPointPosition()
        {
           return _points.IndexOf(this);
        }


        /*
         *  Service API
         */
        public void InsertPoint()
        {
            Insert();
        }
        public Point? UpdatePoint (Point? point)
        {
            if (!Update(point)) return null; 
            return point!;
        }

        public Point? DeletePoint()
        {
            return Delete();
        }
        
        public Point? GetPoint()
        {
            return GetPointOrNull();
        }

        public static List<Point> GetAllPoints()
        {
            return new List<Point>(_points);
        }

    }
}
