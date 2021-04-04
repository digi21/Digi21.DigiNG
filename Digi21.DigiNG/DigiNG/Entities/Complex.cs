using System.Collections;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class Complex : ReadOnlyComplex
    {
        public Complex(Code code) => throw null;
        public Complex(IEnumerable<Code> codes) => throw null;

        public new IList<Entity> Entities => throw null;
    }
}
