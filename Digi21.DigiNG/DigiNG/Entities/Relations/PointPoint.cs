using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities.Relations
{
    public static class PointPoint
    {
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Coincident(ReadOnlyPoint a, ReadOnlyPoint b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyPoint a, ReadOnlyPoint b) { throw null; }
    }
}
