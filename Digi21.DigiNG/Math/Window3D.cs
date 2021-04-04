using System.Drawing;

namespace Digi21.Math
{
    public struct Window3D : IWindow3D, IDesplazable
    {
        public double? Xmin { get => throw null; set => throw null; }
        public double Ymin { get => throw null; set => throw null; }
        public double Zmin { get => throw null; set => throw null; }
        public double Xmax { get => throw null; set => throw null; }
        public double Ymax { get => throw null; set => throw null; }
        public double Zmax { get => throw null; set => throw null; }
        public bool Valid => throw null;
        public double Width => throw null;
        public double Height => throw null;
        public double Depth => throw null;
        public Point3D Center => throw null;
        public Point3D NW => throw null;
        public Point3D N => throw null;
        public Point3D NE => throw null;
        public Point3D E => throw null;
        public Point3D SE => throw null;
        public Point3D S => throw null;
        public Point3D SW => throw null;
        public Point3D W => throw null;
        public Window3D(Point3D point) { throw null; }
        public Window3D(double xMin, double yMin, double zMin, double xMax, double yMax, double zMax) { throw null; }
        public Window3D(IWindow3D window) { throw null; }
        public static explicit operator Window2D(Window3D window) { throw null; }
        public void Offset(double x, double y, double z) { throw null; }
        public void Offset(double x, double y) { throw null; }
        public void Offset(Point3D offset) { throw null; }
        public void Offset(Point2D offset) { throw null; }
        public void Inflate(double x, double y, double z) { throw null; }
        public void Inflate(double x, double y) { throw null; }
        public void Inflate(Point3D size) { throw null; }
        public void Inflate(Size size) { throw null; }
        public static Window3D Union(IWindow3D window, Point3D point) { throw null; }
        public static Window3D Union(Window3D window, Point3D point) { throw null; }
        public static Window3D Union(IWindow3D window, PointF point) { throw null; }
        public static Window3D Union(Window3D window, PointF point) { throw null; }
        public static Window3D Union(IWindow3D window, Point point) { throw null; }
        public static Window3D Union(Window3D window, Point point) { throw null; }
        public static Window3D Union(IWindow3D a, IWindow3D b) { throw null; }
        public static Window3D Union(Window3D a, Window3D b) { throw null; }
        public static Window3D Union(IWindow3D window, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax) { throw null; }
        public static Window3D Union(Window3D window, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax) { throw null; }
        public void Union(IWindow3D window) { throw null; }
        public void Union(Window3D window) { throw null; }
        public void Union(Point3D point) { throw null; }
        public void Union(PointF point) { throw null; }
        public void Union(Point point) { throw null; }
        public void Union(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax) { throw null; }
        public bool Contains(IWindow3D window) { throw null; }
        public bool Contains(Window3D window) { throw null; }
        public bool Contains(Point3D point) { throw null; }
        public bool Contains(PointF point) { throw null; }
        public bool Contains(Point point) { throw null; }
        public bool Intersect(Window3D window) { throw null; }
        private bool Intersect2D(double xMin, double xMax, double yMin, double yMax) { throw null; }
        public bool Intersect2D(Point3D point) { throw null; }
        public bool Intersect2D(Window3D window) { throw null; }
        public override string ToString() { throw null; }
        private bool Contains3D(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax) { throw null; }
        private bool Contains2D(double xMin, double xMax, double yMin, double yMax) { throw null; }
        private bool Intersect3D(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax) { throw null; }
        static Window3D() { throw null; }
    }
}