using System.Runtime.InteropServices;

namespace Digi21.Math
{
    public static class Precision
    {
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsDistinct(this double valueA, double valueB) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsEqual(this double valueA, double valueB) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsGreater(this double valueA, double valueB) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsGreaterOrEqual(this double valueA, double valueB) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsLower(this double valueA, double valueB) { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public static bool IsLowerOrEqual(this double valueA, double valueB) { throw null; }

        public static double Epsilon { get; set; }
    }
}
