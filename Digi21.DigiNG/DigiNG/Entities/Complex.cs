using System.Collections;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public class Complex : ReadOnlyComplex
    {
        public Complex(Code code) => throw null;
        public Complex(IEnumerable<Code> codigos) => throw null;

        public new EntityCollection Entities => throw null;

        public class EntityCollection : IList<Entity>
        {
            public void Add(Entity item) => throw null;
            public void Clear() => throw null;

            public bool Contains(Entity entity) => throw null;
            public void CopyTo(Entity[] array, int arrayIndex) => throw null;
            public IEnumerator<Entity> GetEnumerator() => throw null;
            IEnumerator IEnumerable.GetEnumerator() => throw null;
            public int IndexOf(Entity item) => throw null;
            public void Insert(int index, Entity item) => throw null;

            public bool Remove(Entity item) => throw null;
            public void RemoveAt(int index) => throw null;

            public Entity this[int index] { get => throw null; set => throw null; }

            public bool IsReadOnly => throw null;
            public int Count => throw null;
        }
    }
}
