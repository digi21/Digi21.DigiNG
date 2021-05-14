
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public struct Code
    {
        public Code(string name, int? table, int? id) => throw null;
        public Code(string name, int table, int id) => throw null;
        public Code(string name) => throw null;
        public Code(string name, IDictionary<string, object> atributes) => throw null;
        public string Name => throw null;
        public int? Table => throw null;
        public int? Id => throw null;
        public bool Visible { get => throw null; set => throw null; }
        public bool VisiblePhotogrammetricWindow { get => throw null; set => throw null; }
        public IDictionary<string, object> Attributes => throw null;
        public static bool operator ==(Code a, Code b) => throw null;
        public static bool operator !=(Code a, Code b) => throw null;
        public static string Compose(string stringToCompose, string wildCard) => throw null;
        public static bool Compare(string codeNameA, string codeNameB) => throw null;
        public override string ToString() => throw null;
    }
}
