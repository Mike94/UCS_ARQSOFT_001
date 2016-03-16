using SGISystem.Helpers.DataAccess;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class BaseDataRepository<TEntity> : DataEntity<TEntity>, IBaseDataRepository<TEntity>
    {
        public BaseDataRepository(String nameSP)
            : base(nameSP)
        {

        }

        public IList<TEntity> Select(CTransaction transaction)
        {
            return base.InnerSelect(transaction);
        }

        public TEntity Insert(CTransaction transaction)
        {
            return (TEntity) base.InnerInsert(transaction);
        }

        public TEntity Update(CTransaction transaction)
        {
            return (TEntity) base.InnerUpdate(transaction);
        }

        public TEntity Delete(CTransaction transaction)
        {
            return (TEntity) base.InnerDelete(transaction);
        }
    }
}
