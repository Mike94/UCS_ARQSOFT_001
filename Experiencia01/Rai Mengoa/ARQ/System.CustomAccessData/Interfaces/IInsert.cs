using System;
using System.CustomAccessData.Transactions;

namespace System.CustomAccessData.Interfaces
{
    public interface IInsert<Entity>
    {
        Entity Insert(Entity entity, CTransaction transaction);
    }
}
