using Digi21.Math;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyLine : Entity, ICloseable, ISnapable, IClippable, ITrimable
    {
        public PointPosition AnalyzePointPosition(Point3D coordinate) => throw null;
        public IEnumerable<Entity> Clip(ReadOnlyLine limit) => throw null;
        public new Line Clone() => throw null;
        public Point3D Distance(Point3D coordinate) => throw null;
        public double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment) => throw null;
        public double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex) => throw null; 
        public sealed override string ToString() => throw null;
        public IEnumerable<Polygon> Trim(ReadOnlyLine limit, bool coordinateZFromThisEntity) => throw null;
        public double Area => throw null;
        public double Perimeter3D => throw null;
        public double Perimeter => throw null;
        public Point3D InteriorPoint => throw null;
        public bool ClosedXYZ => throw null;
        public bool Closed => throw null;
        public Segment LastSegment => throw null;
        public Segment FirstSegment => throw null;
        public Point3D LastVertex => throw null;
        public Point3D FirstVertex => throw null;
        public Point3DReadOnlyCollection Points => throw null;
    }
}
