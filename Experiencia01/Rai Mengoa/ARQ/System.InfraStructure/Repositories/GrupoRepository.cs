using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.InfraStructure.Repositories
{
    public class GrupoRepository : IGrupoRepository
    {
        public EntityGrupo SelectByKey(KeyGrupo okey, CTransaction oCTransaction)
        {
            try
            {
                DataGrupoRepository data = new DataGrupoRepository(EntityGrupo.Empty, "grupo");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityGrupo> Select(EntityGrupo oEntityGrupo, CTransaction oCTransaction)
        {
            try
            {
                DataGrupoRepository data = new DataGrupoRepository(oEntityGrupo, "grupo");
                return data.Select(oCTransaction);
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
                DataGrupoRepository data = new DataGrupoRepository(EntityGrupoPaginacion.Empty, "grupo");
                return data.SelectPagging(ref oEntityGrupoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Insert(EntityGrupo oEntityGrupo, CTransaction oCTransaction)
        {
            try
            {
                DataGrupoRepository data = new DataGrupoRepository(oEntityGrupo, "grupo");
                oEntityGrupo = data.Insert(oCTransaction);
                KeyGrupo key = new KeyGrupo(DataCreator.CreateInt32(data.CollectionParams.GetParameter("IDGrupo").Value));
                oEntityGrupo.Key = key;

                return oEntityGrupo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Update(EntityGrupo oEntityGrupo, CTransaction oCTransaction)
        {
            try
            {
                DataGrupoRepository data = new DataGrupoRepository(oEntityGrupo, "grupo");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityGrupo Delete(EntityGrupo oEntityGrupo, CTransaction oCTransaction)
        {
            try
            {
                DataGrupoRepository data = new DataGrupoRepository(oEntityGrupo, "grupo");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
