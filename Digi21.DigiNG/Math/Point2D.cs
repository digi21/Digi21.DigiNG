﻿
namespace Digi21.Math
{
    public struct Point2D : IDesplazable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point2D(Point3D point) { throw null; }
        public Point2D(double value) { throw null; }
        public Point2D(double x, double y) { throw null; }
        public static explicit operator Point3D(Point2D point) { throw null; }
        public static bool operator ==(Point2D a, Point2D b) { throw null; }
        public static bool operator !=(Point2D a, Point2D b) { throw null; }
        public static Point2D operator +(Point2D a, Point2D b) { throw null; }
        public static Point2D operator -(Point2D a, Point2D b) { throw null; }
        public static Point2D operator *(Point2D a, double factor) { throw null; }
        public static Point2D operator /(Point2D a, double factor) { throw null; }
        public static double DotProduct(Point2D a, Point2D b) { throw null; }
        public double Module { get; }
        public static double CalculateModule(Point3D a, Point3D b) { throw null; }
        public static double CalculateModule(Point3D a, Point2D b) { throw null; }
        public static double CalculateModule(Point2D a, Point3D b) { throw null; }
        public static double CalculateModule(Point2D a, Point2D b) { throw null; }
        public double SquaredModule { get; }
        public static double CalculateSquaredModule(Point2D a, Point2D b) { throw null; }
        public Point2D Normalized { get { throw null; } }
        public bool IsEmpty { get; }
        public double Azimuth { get; }
        public void Offset(double x, double y, double z) { throw null; }
        public void Offset(double x, double y) { throw null; }
        public void Offset(Point3D offset) { throw null; }
        public void Offset(Point2D offset) { throw null; }
        public override string ToString() { throw null; }
    }
}
