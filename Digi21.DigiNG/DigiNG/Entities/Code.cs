
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public struct Code
    {
        private string _nombre;
        private int? _tabla;
        private int? _id;
        private ulong _indiceDigiTab;
        private uint _visible;
        private uint _visibleVentanaFotogrametrica;
        private IDictionary<string, object> _attributes;

        public Code(string name, int? table, int? id) => throw null;
        public Code(string name, int table, int id) => throw null;
        public Code(string name) => throw null;
        public Code(string name, IDictionary<string, object> attributes) => throw null;
        public string Name => throw null;
        public int? Table => throw null;
        public int? Id => throw null;
        public uint Visible { get => throw null; set => throw null; }
        public uint VisiblePhotogrammetricWindow { get => throw null; set => throw null; }
        public IDictionary<string, object> Attributes { get => throw null; set => throw null; }
        public static bool operator ==(Code a, Code b) => throw null;
        public static bool operator !=(Code a, Code b) => throw null;
        public static string Compose(string stringToCompose, string wildCard) => throw null;
        public static bool Compare(string codeNameA, string codeNameB) => throw null;
        public override string ToString() => throw null;
    }
}
