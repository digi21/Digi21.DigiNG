using Digi21.Math;

namespace Digi21.DigiNG.Entities
{
    public interface ISnapable
    {
        Point3D Distance(Point3D coordinate);
        double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment);
        double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex);
    }
}
