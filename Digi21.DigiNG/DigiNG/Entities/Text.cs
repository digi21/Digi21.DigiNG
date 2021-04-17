using Digi21.Math;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class Text : ReadOnlyText, IDesplazable
    {
        public Text(Code code) => throw null;
        public Text(IEnumerable<Code> codigos) => throw null;
        public new void Offset(Point2D offset) => throw null;
        public new void Offset(Point3D offset) => throw null;
        public new void Offset(double x, double y) => throw null;
        public new void Offset(double x, double y, double z) => throw null;
        public new TextJustification Justification { get => throw null; set => throw null; }
        public new double TextHeight { get => throw null; set => throw null; }
        public new double Rotation { get => throw null; set => throw null; }
        public new Point3D Coordinate { get => throw null; set => throw null; }
        public new string Txt { get => throw null; set => throw null; }
    }
}
