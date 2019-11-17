using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public class CodeCollection : IList<Code>
    {
        public void Add(Code item) { throw null; }
        public void Clear() { throw null; }
        [return: MarshalAs(UnmanagedType.U1)]
        public bool Contains(Code entidad) { throw null; }
        public void CopyTo(Code[] array, int arrayIndex) { throw null; }
        public IEnumerator<Code> GetEnumerator() { throw null; }
        IEnumerator IEnumerable.GetEnumerator() { throw null; }
        public int IndexOf(Code item) { throw null; }
        public void Insert(int index, Code item) { throw null; }

        [return: MarshalAs(UnmanagedType.U1)]
        public bool Remove(Code item) { throw null; }
        public void RemoveAt(int index) { throw null; }
        public Code this[string name] { get { throw null; } set { throw null; } }
        public Code this[int index] { get { throw null; } set { throw null; } }
        public bool IsReadOnly { [return: MarshalAs(UnmanagedType.U1)] get; }
        public int Count { get; }
    }
}
