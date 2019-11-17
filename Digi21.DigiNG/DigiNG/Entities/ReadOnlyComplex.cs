using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public class ReadOnlyComplex : Entity
    {
        public new Complex Clone() { throw null; }
        public override string ToString() { throw null; }

        public EntityReadOnlyCollection Entities { get; }

        [Browsable(false)]
        public class EntityReadOnlyCollection : IReadOnlyList<Entity>
        {
            [return: MarshalAs(UnmanagedType.U1)]
            public bool Contains(Entity entity) { throw null; }
            public void CopyTo(Entity[] array, int arrayIndex) { throw null; }
            public IEnumerator<Entity> GetEnumerator() { throw null; }
            IEnumerator IEnumerable.GetEnumerator() { throw null; }
            public int IndexOf(Entity item) { throw null; }

            public Entity this[int index] { get { throw null; } }
            public int Count { get; }
        }
    }
}
