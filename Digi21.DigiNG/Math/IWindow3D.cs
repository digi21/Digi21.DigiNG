using System.Runtime.InteropServices;

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
        bool Valid { [return: MarshalAs(UnmanagedType.U1)] get; }
        double Zmax { get; set; }
        double Ymax { get; set; }
        double Xmax { get; set; }
        double Zmin { get; set; }
        double Ymin { get; set; }
        double? Xmin { get; set; }
    }
}
