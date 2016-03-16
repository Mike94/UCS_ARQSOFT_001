using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.InfraStructure.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        public EntityCargo SelectByKey(KeyCargo okey, CTransaction oCTransaction)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(EntityCargo.Empty, "cargo");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityCargo> Select(EntityCargo oEntityCargo, CTransaction oCTransaction)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(oEntityCargo, "cargo");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(EntityCargoPaginacion.Empty, "cargo");
                return data.SelectPagging(ref oEntityCargoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Insert(EntityCargo oEntityCargo, CTransaction oCTransaction)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(oEntityCargo, "cargo");
                return data.Insert(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Update(EntityCargo oEntityCargo, CTransaction oCTransaction)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(oEntityCargo, "cargo");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Delete(EntityCargo oEntityCargo, CTransaction oCTransaction)
        {
            try
            {
                DataCargoRepository data = new DataCargoRepository(oEntityCargo, "cargo");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
