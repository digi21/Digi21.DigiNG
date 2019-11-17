using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.Entities
{
    public interface ITrimable
    {
        IEnumerable<Polygon> Trim(ReadOnlyLine limit, [MarshalAs(UnmanagedType.U1)] bool coordinateZFromThisEntity);
    }
}
