using SGISystem.Helpers.DataAccess.Transactions;
using System;

namespace SGISystem.Helpers.DataAccess.Interfaces
{
    public interface IDelete<Entity>
    {
        Entity Delete(Entity entity, CTransaction transaction);
    }
}
