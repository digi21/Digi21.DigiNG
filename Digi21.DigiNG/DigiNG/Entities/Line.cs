using Digi21.Math;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public class Line : ReadOnlyLine, IDesplazable, IDirectionable
    {
        public Line(Code code) { throw null; }
        public Line(IEnumerable<Code> codigos) { throw null; }
        public void ChangeDirection() { throw null; }
        public void Close() { throw null; }
        public new void Offset(Point2D offset) { throw null; }
        public new void Offset(Point3D offset) { throw null; }
        public new void Offset(double x, double y) { throw null; }
        public new void Offset(double x, double y, double z) { throw null; }
        public new Point3DCollection Points { get; }
        public new bool Deleted { [param: MarshalAs(UnmanagedType.U1)] set { throw null; } }
    }
}
