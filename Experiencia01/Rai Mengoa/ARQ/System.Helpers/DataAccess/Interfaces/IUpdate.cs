using SGISystem.Helpers.DataAccess.Transactions;
using System;

namespace SGISystem.Helpers.DataAccess.Interfaces
{
    public interface IUpdate<Entity>
    {
        Entity Update(Entity entity, CTransaction transaction);
    }
}
