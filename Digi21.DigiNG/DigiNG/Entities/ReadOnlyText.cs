using Digi21.Math;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyText : Entity, ISnapable
    {
        public new Text Clone() { throw null; }
        public Point3D Distance(Point3D coordinate) { throw null; }
        public double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment) { throw null; }
        public double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex) { throw null; }
        public override string ToString() { throw null; }
        public TextJustification Justification { get; }
        public double TextHeight { get; }
        public double Rotation { get; }
        public string Txt { get; }
        public Point3D Coordinate { get; }
    }
}
