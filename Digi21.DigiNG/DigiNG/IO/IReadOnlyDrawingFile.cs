using Digi21.DigiNG.Entities;
using System.Collections.Generic;
using Digi21.Math;

namespace Digi21.DigiNG.IO
{
    public interface IReadOnlyDrawingFile 
        : IEnumerable<Entity>
        , IWindow3D
    {
        string Path { get; }
        string ConnectionString { get; }
    }
}
