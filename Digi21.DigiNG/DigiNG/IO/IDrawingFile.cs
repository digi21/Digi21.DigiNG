using Digi21.DigiNG.Entities;
using System.Collections.Generic;

namespace Digi21.DigiNG.IO
{
    public interface IDrawingFile : IReadOnlyDrawingFile
    {
        ReadOnlyComplex Add(Complex complex);
        void Add(Entity entity);
        ReadOnlyLine Add(Line line);
        ReadOnlyPoint Add(Point point);
        ReadOnlyPolygon Add(Polygon polygon);
        ReadOnlyText Add(Text text);
        void Add(IEnumerable<Entity> entities);
        void Delete(Entity entity);
        void Delete(IEnumerable<Entity> entities);
        string Wkt { get; }
        IDictionary<string, int> DatabaseTables { get; }
        bool CanWrite { get; }
        bool CanRead { get; }
        string Path { get; }
    }
}
