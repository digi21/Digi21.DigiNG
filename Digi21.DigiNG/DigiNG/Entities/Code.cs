
namespace Digi21.DigiNG.Entities
{
    public struct Code
    {
        public Code(string name, int? table, int? id) { throw null; }
        public Code(string name, int table, int id) { throw null; }
        public Code(string name) { throw null; }
        public string Name { get; }
        public int? Table { get; }
        public int? Id { get; }
        public bool Visible { get; set; }
        public bool VisiblePhotogrammetricWindow { get; set; }
        public static bool operator ==(Code a, Code b) { throw null; }
        public static bool operator !=(Code a, Code b) { throw null; }
        public static string Compose(string stringToCompose, string wildCard) { throw null; }
        public static bool Compare(string codeNameA, string codeNameB) { throw null; }
        public override string ToString() { throw null; }
    }
}
