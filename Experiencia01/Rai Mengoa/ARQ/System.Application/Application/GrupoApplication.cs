using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using SGISystem.InfraStructure.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGISystem.Domain.Repository;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Entities.Keys;

namespace SGISystem.Application.Application
{
   public  class GrupoApplication : IGrupoApplication
    {
        public GrupoApplication()
        {
            _repo = new GrupoRepository();
        }

        private IGrupoRepository _repo;

        public IGrupoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityGrupo> Select(EntityGrupo oEntityGrupo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityGrupo, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IList<EntityGrupoPaginacion> SelectPagging(ref EntityGrupoPaginacion oEntityGrupoPaginacion)
        {
            try
            {
                return Repo.SelectPagging(ref oEntityGrupoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Insert(EntityGrupo oEntityGrupo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityGrupo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Update(Domain.Entities.EntityGrupo oEntityGrupo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityGrupo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Delete(Domain.Entities.EntityGrupo oEntityGrupo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityGrupo, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityGrupo SelectByKey(KeyGrupo oKeyGrupo)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyGrupo, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
