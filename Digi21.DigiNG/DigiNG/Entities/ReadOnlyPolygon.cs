﻿using Digi21.Math;
using System.Collections;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyPolygon : Entity, ISnapable, IClippable, ITrimable
    {
        public PointPosition AnalyzePointPosition(Point3D point) { throw null; }
        public IEnumerable<Entity> Clip(ReadOnlyLine limit) { throw null; }
        public new Polygon Clone() { throw null; }
        public Point3D Distance(Point3D coordinate) { throw null; }
        public double NearestSegment(Point3D coordinate, out Point3D calculatedCoordinate, out int segment) { throw null; }
        public double NearestVertex(Point3D coordinate, out Point3D nearestVertex, out int vertex) { throw null; }
        public override string ToString() { throw null; }
        public IEnumerable<Polygon> Trim(ReadOnlyLine limit, bool coordinateZFromThisEntity) { throw null; }
        public double Area => throw null;
        public ReadOnlyLineReadOnlyCollection Holes => throw null;
        public Point3DReadOnlyCollection Points => throw null;
        public Point3D InteriorPoint => throw null;

        public class ReadOnlyLineReadOnlyCollection : IReadOnlyList<ReadOnlyLine>
        {
            public bool Contains(ReadOnlyLine entity) { throw null; }
            public void CopyTo(ReadOnlyLine[] array, int arrayIndex) { throw null; }
            public IEnumerator<ReadOnlyLine> GetEnumerator() { throw null; }
            IEnumerator IEnumerable.GetEnumerator() { throw null; }
            public int IndexOf(ReadOnlyLine item) { throw null; }
            public ReadOnlyLine this[int index] { get { throw null; } }
            public int Count => throw null;
        }
    }
}
