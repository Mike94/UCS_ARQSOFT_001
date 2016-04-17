using System;
using System.CustomAccessData.Transactions;

namespace System.CustomAccessData.Interfaces
{
    public interface IUpdate<Entity>
    {
        Entity Update(Entity entity, CTransaction transaction);
    }
}
