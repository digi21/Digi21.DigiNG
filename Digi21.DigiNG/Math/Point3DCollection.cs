﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.Math
{
    public class Point3DCollection : IList<Point3D>
    {
        public void Add(Point3D item) { throw null; }
        public void Add(IEnumerable<Point3D> points) { throw null; }
        public void Clear() { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public bool Contains(Point3D vertice) { throw null; }
        public void CopyTo(Point3D[] array, int arrayIndex) { throw null; }
        public IEnumerator<Point3D> GetEnumerator() { throw null; }
        IEnumerator IEnumerable.GetEnumerator() { throw null; }
        public int IndexOf(Point3D item) { throw null; }
        public void Insert(int index, Point3D item) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public bool Remove(Point3D item) { throw null; }
        public void RemoveAt(int index) { throw null; }

        public Point3D this[int index] { get { throw null; } set { throw null; } }
        public int Count { get; }
        public bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; }
    }
}