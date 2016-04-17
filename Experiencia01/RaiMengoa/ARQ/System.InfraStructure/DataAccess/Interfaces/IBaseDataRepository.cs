using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;

namespace SGISystem.InfraStructure.DataAccess.Interfaces
{
    public interface IBaseDataRepository<TEntity>
    {
        IList<TEntity> Select(CTransaction transaction);
        TEntity Insert(CTransaction transaction);
        TEntity Update(CTransaction transaction);
        TEntity Delete(CTransaction transaction);
    }
}
