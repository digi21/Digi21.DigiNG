using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities.Relations
{
    public static class LineArea
    {
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Across(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Across(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Adjacent(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Adjacent(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool EndpointJoin(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool EndpointJoin(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Join(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Join(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool TerminatesWithin(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool TerminatesWithin(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Within(ReadOnlyLine line, ReadOnlyLine area) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Within(ReadOnlyLine line, ReadOnlyPolygon area) { throw null; }
    }
}
