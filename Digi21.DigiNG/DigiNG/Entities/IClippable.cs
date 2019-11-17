using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public interface IClippable
    {
        IEnumerable<Entity> Clip(ReadOnlyLine limit);
    }
}
