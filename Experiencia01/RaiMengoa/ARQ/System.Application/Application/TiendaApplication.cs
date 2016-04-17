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
    public class TiendaApplication : ITiendaApplication
    {
        public TiendaApplication()
        {
            _repo = new TiendaRepository();
        }

        private ITiendaRepository _repo;

        public ITiendaRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityTienda> Select(EntityTienda oEntityTienda)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityTienda, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion)
        {
            try
            {
                return Repo.SelectPagging(ref oEntityTiendaPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Insert(EntityTienda oEntityTienda)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityTienda, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Update(Domain.Entities.EntityTienda oEntityTienda)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityTienda, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Delete(Domain.Entities.EntityTienda oEntityTienda)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityTienda, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityTienda SelectByKey(KeyTienda oKeyTienda)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyTienda, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
