using System.Collections;
using System.Collections.Generic;

namespace Digi21.Math
{
    public class Point3DReadOnlyCollection : IReadOnlyList<Point3D>
    {
        public bool Contains(Point3D vertice) => throw null;
        public void CopyTo(Point3D[] array, int arrayIndex) => throw null;
        public IEnumerator<Point3D> GetEnumerator() => throw null;
        IEnumerator IEnumerable.GetEnumerator() => throw null;
        public int IndexOf(Point3D item) => throw null;
        public Point3D this[int index] { get => throw null; }
        public int Count => throw null;
    }
}
