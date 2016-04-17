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
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public IList<EntityDepartamento> Select(EntityDepartamento oEntityDepartamento, CTransaction oCTransaction)
        {
            try
            {
                DataDepartamentoRepository data = new DataDepartamentoRepository(oEntityDepartamento, "departamento");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDepartamento SelectByKey(KeyDepartamento okey, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public IList<EntityDepartamentoPaginacion> SelectPagging(ref EntityDepartamentoPaginacion oValuePaginacion)
        {
            throw new NotImplementedException();
        }

        public EntityDepartamento Insert(EntityDepartamento oValue, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public EntityDepartamento Update(EntityDepartamento oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public EntityDepartamento Delete(EntityDepartamento oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
