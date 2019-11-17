using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public interface IJoinable
    {
        IEnumerable<Entity> Join(Entity entity);
    }
}
