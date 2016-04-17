using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application
{
    public class CargoApplication : ICargoApplication
    {
        public CargoApplication()
        {
            _repo = new CargoRepository();
        }

        private ICargoRepository _repo;

        public ICargoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityCargo> Select(EntityCargo oEntityCargo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityCargo, oCTransaction);
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
                return Repo.SelectPagging(ref oEntityCargoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Insert(EntityCargo oEntityCargo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityCargo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Update(Domain.Entities.EntityCargo oEntityCargo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityCargo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Delete(Domain.Entities.EntityCargo oEntityCargo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityCargo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityCargo SelectByKey(KeyCargo oKeyCargo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyCargo, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
