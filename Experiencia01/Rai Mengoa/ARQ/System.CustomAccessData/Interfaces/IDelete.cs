using System;
using System.CustomAccessData.Transactions;

namespace System.CustomAccessData.Interfaces
{
    public interface IDelete<Entity>
    {
        Entity Delete(Entity entity, CTransaction transaction);
    }
}
