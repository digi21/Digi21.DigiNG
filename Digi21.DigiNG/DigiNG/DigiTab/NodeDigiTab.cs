using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    public class NodeDigiTab : IDisposable
    {
        public NodeDigiTab(string name) { throw null; }
        public void Dispose() { throw null; }
        public int Priority { get; set; }
        public string ColorPhotogrammetric { get; set; }
        public string Color { get; set; }
        public Dictionary<string, string> Values { get; }
        public IEnumerable<string> Alias { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Table { get; set; }
        public bool Visibility { get; }
        public string Description { get; set; }
        public string Name { get; }
    }
}
