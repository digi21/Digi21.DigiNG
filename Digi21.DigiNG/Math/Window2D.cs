using System.Drawing;

namespace Digi21.Math
{
    public struct Window2D : IWindow2D, IDesplazable
    {
        public static readonly Window2D WholeWorld;
        public double? Xmin { get; set; }
        public double Ymin { get; set; }
        public double Xmax { get; set; }
        public double Ymax { get; set; }
        public bool Valid { get; }
        public double Width { get; }
        public double Height { get; }
        public Point2D Center { get; }
        public Point2D NW { get; }
        public Point2D N { get; }
        public Point2D NE { get; }
        public Point2D E { get; }
        public Point2D SE { get; }
        public Point2D S { get; }
        public Point2D SW { get; }
        public Point2D W { get; }
        public Window2D(Point3D point) { throw null; }
        public Window2D(Point2D point) { throw null; }
        public Window2D(double xMin, double yMin, double xMax, double yMax) { throw null; }
        public Window2D(double? xMin, double yMin, double xMax, double yMax) { throw null; }
        public Window2D(IWindow3D window) { throw null; }
        public Window2D(IWindow2D window) { throw null; }
        public void Offset(double x, double y, double z) { throw null; }
        public void Offset(double x, double y) { throw null; }
        public void Offset(Point3D offset) { throw null; }
        public void Offset(Point2D offset) { throw null; }
        public void Inflate(double x, double y) { throw null; }
        public void Inflate(Point2D size) { throw null; }
        public void Inflate(Size size) { throw null; }
        public static Window2D Union(IWindow3D window, Point3D point) { throw null; }
        public static Window2D Union(IWindow3D window, Point2D point) { throw null; }
        public static Window2D Union(IWindow2D window, Point3D point) { throw null; }
        public static Window2D Union(IWindow2D window, Point2D point) { throw null; }
        public static Window2D Union(Window3D window, Point3D point) { throw null; }
        public static Window2D Union(Window3D window, Point2D point) { throw null; }
        public static Window2D Union(Window2D window, Point3D point) { throw null; }
        public static Window2D Union(Window2D window, Point2D point) { throw null; }
        public static Window2D Union(IWindow3D window, PointF point) { throw null; }
        public static Window2D Union(IWindow2D window, PointF point) { throw null; }
        public static Window2D Union(Window3D window, PointF point) { throw null; }
        public static Window2D Union(Window2D window, PointF point) { throw null; }
        public static Window2D Union(IWindow3D window, Point point) { throw null; }
        public static Window2D Union(IWindow2D window, Point point) { throw null; }
        public static Window2D Union(Window3D window, Point point) { throw null; }
        public static Window2D Union(Window2D window, Point point) { throw null; }
        public static Window2D Union(IWindow3D a, IWindow3D b) { throw null; }
        public static Window2D Union(IWindow2D a, IWindow3D b) { throw null; }
        public static Window2D Union(IWindow3D a, IWindow2D b) { throw null; }
        public static Window2D Union(IWindow2D a, IWindow2D b) { throw null; }
        public static Window2D Union(IWindow3D a, Window3D b) { throw null; }
        public static Window2D Union(IWindow3D a, Window2D b) { throw null; }
        public static Window2D Union(IWindow2D a, Window3D b) { throw null; }
        public static Window2D Union(IWindow2D a, Window2D b) { throw null; }
        public static Window2D Union(Window3D a, IWindow3D b) { throw null; }
        public static Window2D Union(Window3D a, IWindow2D b) { throw null; }
        public static Window2D Union(Window2D a, IWindow3D b) { throw null; }
        public static Window2D Union(Window2D a, IWindow2D b) { throw null; }
        public static Window2D Union(Window3D a, Window3D b) { throw null; }
        public static Window2D Union(Window3D a, Window2D b) { throw null; }
        public static Window2D Union(Window2D a, Window3D b) { throw null; }
        public static Window2D Union(Window2D a, Window2D b) { throw null; }
        public static Window2D Union(IWindow3D window, double xMin, double xMax, double yMin, double yMax) { throw null; }
        public static Window2D Union(IWindow2D window, double xMin, double xMax, double yMin, double yMax) { throw null; }
        public static Window2D Union(Window3D window, double xMin, double xMax, double yMin, double yMax) { throw null; }
        public static Window2D Union(Window2D window, double xMin, double xMax, double yMin, double yMax) { throw null; }
        public void Union(IWindow3D window) { throw null; }
        public void Union(IWindow2D window) { throw null; }
        public void Union(Window3D window) { throw null; }
        public void Union(Window2D window) { throw null; }
        public void Union(Point3D point) { throw null; }
        public void Union(Point2D point) { throw null; }
        public void Union(PointF point) { throw null; }
        public void Union(Point point) { throw null; }
        public void Union(double xMin, double yMin, double xMax, double yMax) { throw null; }
        public static Window2D Intersection(double? xMinA, double xMaxA, double yMinA, double yMaxA, double? xMinB, double xMaxB, double yMinB, double yMaxB) { throw null; }
        public static Window2D Intersection(IWindow3D windowA, IWindow3D windowB) { throw null; }
        public static Window2D Intersection(IWindow3D windowA, IWindow2D windowB) { throw null; }
        public static Window2D Intersection(IWindow2D windowA, IWindow3D windowB) { throw null; }
        public static Window2D Intersection(IWindow2D windowA, IWindow2D windowB) { throw null; }
        public static Window2D Intersection(IWindow3D windowA, Window3D windowB) { throw null; }
        public static Window2D Intersection(IWindow3D windowA, Window2D windowB) { throw null; }
        public static Window2D Intersection(IWindow2D windowA, Window3D windowB) { throw null; }
        public static Window2D Intersection(IWindow2D windowA, Window2D windowB) { throw null; }
        public static Window2D Intersection(Window3D windowA, IWindow3D windowB) { throw null; }
        public static Window2D Intersection(Window3D windowA, IWindow2D windowB) { throw null; }
        public static Window2D Intersection(Window2D windowA, IWindow3D windowB) { throw null; }
        public static Window2D Intersection(Window2D windowA, IWindow2D windowB) { throw null; }
        public static Window2D Intersection(Window3D windowA, Window3D windowB) { throw null; }
        public static Window2D Intersection(Window3D windowA, Window2D windowB) { throw null; }
        public static Window2D Intersection(Window2D windowA, Window3D windowB) { throw null; }
        public static Window2D Intersection(Window2D windowA, Window2D windowB) { throw null; }
        public Window2D Intersection(double? xMin, double xMax, double yMin, double yMax) { throw null; }
        public Window2D Intersection(IWindow3D window) { throw null; }
        public Window2D Intersection(IWindow2D window) { throw null; }
        public Window2D Intersection(Window3D window) { throw null; }
        public Window2D Intersection(Window2D window) { throw null; }
        public static bool Contains(double? xMinA, double xMaxA, double yMinA, double yMaxA, double? xMinB, double xMaxB, double yMinB, double yMaxB) { throw null; }
        public static bool Contains(IWindow3D wndA, Window3D wndB) { throw null; }
        public static bool Contains(IWindow3D wndA, Window2D wndB) { throw null; }
        public static bool Contains(IWindow2D wndA, Window3D wndB) { throw null; }
        public static bool Contains(IWindow2D wndA, Window2D wndB) { throw null; }
        public static bool Contains(Window3D wndA, IWindow3D wndB) { throw null; }
        public static bool Contains(Window3D wndA, IWindow2D wndB) { throw null; }
        public static bool Contains(Window2D wndA, IWindow3D wndB) { throw null; }
        public static bool Contains(Window2D wndA, IWindow2D wndB) { throw null; }
        public static bool Contains(Window3D wndA, Window3D wndB) { throw null; }
        public static bool Contains(Window3D wndA, Window2D wndB) { throw null; }
        public static bool Contains(Window2D wndA, Window3D wndB) { throw null; }
        public static bool Contains(Window2D wndA, Window2D wndB) { throw null; }
        public bool Contains(double xMin, double xMax, double yMin, double yMax) { throw null; }
        public bool Contains(IWindow3D window) { throw null; }
        public bool Contains(IWindow2D window) { throw null; }
        public bool Contains(Window3D window) { throw null; }
        public bool Contains(Window2D window) { throw null; }
        public bool Contains(Point3D point) { throw null; }
        public bool Contains(Point2D point) { throw null; }
        public bool Contains(PointF point) { throw null; }
        public bool Contains(Point point) { throw null; }
        public static bool Intersects(double xMinA, double xMaxA, double yMinA, double yMaxA, double xMinB, double xMaxB, double yMinB, double yMaxB) { throw null; }
        public static bool Intersects(double? xMinA, double xMaxA, double yMinA, double yMaxA, double? xMinB, double xMaxB, double yMinB, double yMaxB) { throw null; }
        public static bool Intersects(IWindow3D windowA, IWindow3D windowB) { throw null; }
        public static bool Intersects(IWindow3D windowA, IWindow2D windowB) { throw null; }
        public static bool Intersects(IWindow2D windowA, IWindow3D windowB) { throw null; }
        public static bool Intersects(IWindow2D windowA, IWindow2D windowB) { throw null; }
        public static bool Intersects(Window3D windowA, Window3D windowB) { throw null; }
        public static bool Intersects(Window3D windowA, Window2D windowB) { throw null; }
        public static bool Intersects(Window2D windowA, Window3D windowB) { throw null; }
        public static bool Intersects(Window2D windowA, Window2D windowB) { throw null; }
        public bool Intersects(double xMin, double xMax, double yMin, double yMax) { throw null; }
        public bool Intersects(double? xMin, double xMax, double yMin, double yMax) { throw null; }
        public bool Intersects(IWindow3D window) { throw null; }
        public bool Intersects(IWindow2D window) { throw null; }
        public bool Intersects(Window3D window) { throw null; }
        public bool Intersects(Window2D window) { throw null; }
        public override string ToString() { throw null; }
        static Window2D() { throw null; }
    }
}
