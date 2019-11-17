﻿using Digi21.Math;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public class Polygon : ReadOnlyPolygon
    {
        public Polygon(Code codigo) { throw null; }
        public Polygon(IEnumerable<Code> codigos) { throw null; }
        public static Polygon JoinPolygons(Entity a, Entity b) { throw null; }
        public new LineCollection Holes { get; }
        public new Point3DCollection Points { get { throw null; } }

        public class LineCollection : IList<Line>
        {
            public void Add(Line item) { throw null; }
            public void Clear() { throw null; }

            [return: MarshalAs(UnmanagedType.U1)]
            public bool Contains(Line entity) { throw null; }
            public void CopyTo(Line[] array, int arrayIndex) { throw null; }
            public IEnumerator<Line> GetEnumerator() { throw null; }
            IEnumerator IEnumerable.GetEnumerator() { throw null; }
            public int IndexOf(Line item) { throw null; }
            public void Insert(int index, Line item) { throw null; }

            [return: MarshalAs(UnmanagedType.U1)]
            public bool Remove(Line item) { throw null; }
            public void RemoveAt(int index) { throw null; }

            public Line this[int index] { get { throw null; } set { throw null; } }
            public bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; }
            public int Count { get; }
        }
    }
}