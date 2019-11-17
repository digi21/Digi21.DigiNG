using Digi21.Math;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyPoint : Entity, ISnapable
    {
        public new Point Clone() { throw null; }
        public Point3D Distance(Point3D coordinate) { throw null; }
        public double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment) { throw null; }
        public double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex) { throw null; }
        public override string ToString() { throw null; }
        public double Rotation { get; }
        public Point3D Coordinate { get; }
    }
}
