using Digi21.DigiNG.Entities;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Digi21.DigiNG.DigiTab
{
    public interface ITrigger
    {
        Entity AnalyzeEntity(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes, [MarshalAs(UnmanagedType.U1)] bool addingEntity);
    }
}
