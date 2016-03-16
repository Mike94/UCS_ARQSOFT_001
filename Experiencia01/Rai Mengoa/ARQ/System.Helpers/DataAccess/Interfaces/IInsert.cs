using SGISystem.Helpers.DataAccess.Transactions;
using System;

namespace SGISystem.Helpers.DataAccess.Interfaces
{
    public interface IInsert<Entity>
    {
        Entity Insert(Entity entity, CTransaction transaction);
    }
}
