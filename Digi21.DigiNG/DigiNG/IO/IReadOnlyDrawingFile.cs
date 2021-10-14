using Digi21.DigiNG.Entities;
using System.Collections.Generic;

namespace Digi21.DigiNG.IO
{
    public interface IReadOnlyDrawingFile : IEnumerable<Entity>
    {
        string Path { get; }
        string ConnectionString { get; }
    }
}
