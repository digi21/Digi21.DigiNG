using Digi21.DigiNG.Entities;
using System.Collections.Generic;

namespace Digi21.DigiNG.IO
{
    public interface IReadOnlyDrawingFile : IList<Entity>
    {
        // Warning: Properties with arguments are not supported in C#. Getter of a DatabaseAttributes property was decompiled as a method.
        IDictionary<string, IDictionary<string, object>> get_DatabaseAttributes(Entity entity);
    }
}
