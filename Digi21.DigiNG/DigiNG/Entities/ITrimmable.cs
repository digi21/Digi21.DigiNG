using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public interface ITrimable
    {
        IEnumerable<Polygon> Trim(ReadOnlyLine limit, bool coordinateZFromThisEntity);
    }
}
