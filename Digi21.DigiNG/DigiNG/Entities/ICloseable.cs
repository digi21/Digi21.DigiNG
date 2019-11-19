using Digi21.Math;

namespace Digi21.DigiNG.Entities
{
    public interface ICloseable
    {
        PointPosition AnalyzePointPosition(Point3D coordinate);
        Point3D InteriorPoint { get; }
        bool ClosedXYZ { get; }
        bool Closed { get; }
    }
}
