using Digi21.Math;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class Point : ReadOnlyPoint, IDesplazable
    {
        public Point(Code code) => throw null;
        public Point(IEnumerable<Code> codigos) => throw null;
        public new void Offset(Point2D offset) => throw null;
        public new void Offset(Point3D offset) => throw null;
        public new void Offset(double x, double y) => throw null;
        public new void Offset(double x, double y, double z) => throw null;
        public new double Rotation { set => throw null; }
        public new Point3D Coordinate { set => throw null; }
    }
}
