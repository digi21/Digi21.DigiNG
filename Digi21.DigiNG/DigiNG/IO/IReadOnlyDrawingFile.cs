using Digi21.DigiNG.Entities;
using System.Collections.Generic;

namespace Digi21.DigiNG.IO
{
    public interface IReadOnlyDrawingFile : IEnumerable<Entity>
    {
        IDictionary<string, IDictionary<string, object>> GetDatabaseAttributes(Entity entity);
        string ConnectionString { get; }
    }
}
