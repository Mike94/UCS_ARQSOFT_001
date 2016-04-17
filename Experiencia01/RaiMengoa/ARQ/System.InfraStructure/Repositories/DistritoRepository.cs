using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;

namespace SGISystem.InfraStructure.Repositories
{
    public class DistritoRepository : IDistritoRepository
    {
        public IList<EntityDistrito> Select(EntityDistrito oEntityDistrito, CTransaction oCTransaction)
        {
            try
            {
                DataDistritoRepository data = new DataDistritoRepository(oEntityDistrito, "distrito");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDistrito SelectByKey(KeyDistrito okey, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public IList<EntityDistritoPaginacion> SelectPagging(ref EntityDistritoPaginacion oValuePaginacion)
        {
            throw new NotImplementedException();
        }

        public EntityDistrito Insert(EntityDistrito oValue, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public EntityDistrito Update(EntityDistrito oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public EntityDistrito Delete(EntityDistrito oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
