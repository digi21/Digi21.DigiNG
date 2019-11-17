using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SegmentPointer
    {
        public SegmentPointer(ReadOnlyLine line, int firstVertex, int secondVertex) { throw null; }
        public ReadOnlyLine Line { get; }
        public int FirstVertex { get; }
        public int SecondVertex { get; }
    }
}
