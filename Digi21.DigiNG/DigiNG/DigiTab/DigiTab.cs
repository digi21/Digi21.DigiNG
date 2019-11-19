using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    public sealed class DigiTab : IDisposable
    {
        public void AddCode(NodeDigiTab code) { throw null; }
        public void Dispose() { throw null; }
        public bool HasCode(string name) { throw null; }
        public bool HasCode(string name, bool allowWilcards) { throw null; }
        public static Digi21.DigiNG.DigiTab.DigiTab Load(string path) { throw null; }
        public void Write(string path) { throw null; }
        public IDictionary<string, IList<Tuple<string, Type>>> Tables { get; }
        public IEnumerable<NodeDigiTab> Codes { get; }
        public NodeDigiTab this[string name] { get { throw null; } }
    }
}
