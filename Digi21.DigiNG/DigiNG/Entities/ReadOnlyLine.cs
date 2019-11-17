using Digi21.Math;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyLine : Entity, ICloseable, ISnapable, IClippable, ITrimable
    {
        public PointPosition AnalyzePointPosition(Point3D coordinate) { throw null; }
        public IEnumerable<Entity> Clip(ReadOnlyLine limit) { throw null; }
        public new Line Clone() { throw null; }
        public Point3D Distance(Point3D coordinate) { throw null; }
        public double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment) { throw null; }
        public double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex) { throw null; } 
        public sealed override string ToString() { throw null; }
        public IEnumerable<Polygon> Trim(ReadOnlyLine limit, [MarshalAs(UnmanagedType.U1)] bool coordinateZFromThisEntity) { throw null; }
        public double Area { get; }
        public double Perimeter3D { get; }
        public double Perimeter { get; }
        public Point3D InteriorPoint { get; }
        public bool ClosedXYZ { [return: MarshalAs(UnmanagedType.U1)] get; }
        public bool Closed { [return: MarshalAs(UnmanagedType.U1)] get; }
        public Segment LastSegment { get; }
        public Segment FirstSegment { get; }
        public Point3D LastVertex { get; }
        public Point3D FirstVertex { get; }
        public Point3DReadOnlyCollection Points { get; }
    }
}
