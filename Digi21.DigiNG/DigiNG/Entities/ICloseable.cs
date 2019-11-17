using Digi21.Math;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public interface ICloseable
    {
        PointPosition AnalyzePointPosition(Point3D coordinate);
        Point3D InteriorPoint { get; }
        bool ClosedXYZ { [return: MarshalAs(UnmanagedType.U1)] get; }
        bool Closed { [return: MarshalAs(UnmanagedType.U1)] get; }
    }
}
