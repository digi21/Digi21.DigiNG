using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities.Relations
{
    public static class LineLine
    {
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Across(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Disjoint(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool EndpointJoinEndpoint(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool EndpointJoinExcludingEndpoints(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Equal(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Join(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool Overlap(ReadOnlyLine a, ReadOnlyLine b) { throw null; }
    }
}
