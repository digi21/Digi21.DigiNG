using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    public sealed class DigiTab : IDisposable
    {
        internal DigiTab() => throw null;
        public void AddCode(NodeDigiTab code) => throw null;
        public void Dispose() => throw null;
        public bool HasCode(string name) => throw null;
        public bool HasCode(string name, bool allowWildcards) => throw null;
        public static Digi21.DigiNG.DigiTab.DigiTab Load(string path) => throw null;
        public void Write(string path) => throw null;
        public IDictionary<string, IList<Tuple<string, Type>>> Tables => throw null;
        public IEnumerable<NodeDigiTab> Codes => throw null;
        public NodeDigiTab this[string name] => throw null;
        public string Path => throw null;
        /// <summary>
        /// Topology definitions of the code table, in the order they are stored.
        /// Each access creates new objects with a copy of the data of the table.
        /// </summary>
        public IReadOnlyList<TopologyDefinition> Topologies => throw null;
        /// <summary>
        /// Returns the topology definition with the given name, ignoring case, or <c>null</c> if the code table does not define it.
        /// </summary>
        /// <param name="name">Name of the topology.</param>
        /// <exception cref="System.ArgumentNullException">If <paramref name="name"/> is <c>null</c>.</exception>
        public TopologyDefinition GetTopology(string name) => throw null;
    }
}
