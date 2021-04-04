using Digi21.Math;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class Polygon : ReadOnlyPolygon
    {
        public Polygon(Code codigo) => throw null;
        public Polygon(IEnumerable<Code> codigos) => throw null;
        public static Polygon JoinPolygons(Entity a, Entity b) => throw null;
        public new IList<Line> Holes => throw null;
        public new IList<Point3D> Points { get => throw null; }
    }
}
