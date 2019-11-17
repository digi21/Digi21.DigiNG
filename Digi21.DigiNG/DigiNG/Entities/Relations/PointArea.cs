using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities.Relations
{
    public static class PointArea
    {
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Coincident(ReadOnlyPoint point, ReadOnlyLine line) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Coincident(ReadOnlyPoint point, ReadOnlyPolygon polygon) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyPoint point, ReadOnlyLine line) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyPoint point, ReadOnlyPolygon polygon) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Within(ReadOnlyPoint point, ReadOnlyLine line) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Within(ReadOnlyPoint point, ReadOnlyPolygon polygon) { throw null; }
    }
}
