
namespace Digi21.Math
{
    public interface IWindow3D
    {
        Point3D W { get; }
        Point3D SW { get; }
        Point3D S { get; }
        Point3D SE { get; }
        Point3D E { get; }
        Point3D NE { get; }
        Point3D N { get; }
        Point3D NW { get; }
        Point3D Center { get; }
        double Depth { get; }
        double Height { get; }
        double Width { get; }
        bool Valid { get; }
        double Zmax { get; }
        double Ymax { get; }
        double Xmax { get; }
        double Zmin { get; }
        double Ymin { get; }
        double? Xmin { get; }
    }
}
