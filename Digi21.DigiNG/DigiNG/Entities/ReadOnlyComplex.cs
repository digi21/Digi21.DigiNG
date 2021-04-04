using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyComplex : Entity
    {
        public new Complex Clone() => throw null;
        public override string ToString() => throw null;

        public IEnumerable<Entity> Entities => throw null;
    }
}
