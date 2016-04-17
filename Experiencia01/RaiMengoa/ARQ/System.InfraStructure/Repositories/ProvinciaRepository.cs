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
    public class ProvinciaRepository : IProvinciaRepository
    {
        public IList<EntityProvincia> Select(EntityProvincia oEntityProvincia, CTransaction oCTransaction)
        {
            try
            {
                DataProvinciaRepository data = new DataProvinciaRepository(oEntityProvincia, "Provincia");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityProvincia SelectByKey(KeyProvincia okey, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public IList<EntityProvinciaPaginacion> SelectPagging(ref EntityProvinciaPaginacion oValuePaginacion)
        {
            throw new NotImplementedException();
        }

        public EntityProvincia Insert(EntityProvincia oValue, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public EntityProvincia Update(EntityProvincia oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public EntityProvincia Delete(EntityProvincia oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
