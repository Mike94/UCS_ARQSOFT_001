using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;

namespace SGISystem.InfraStructure.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        public EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(EntityEmpresa.Empty, "empresa");
                return data.SelectByKey(oKeyEmpresa, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(oEntityEmpresa, "empresa");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(EntityEmpresaPaginacion.EmptyPag, "empresa");
                return data.SelectPagging(ref oEntityEmpresaPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa Insert(EntityEmpresa oEntityEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(oEntityEmpresa, "empresa");

                oEntityEmpresa = data.Insert(oCTransaction);
                KeyEmpresa key = new KeyEmpresa(DataCreator.CreateInt32(data.CollectionParams.GetParameter("IDEmpresa").Value));
                oEntityEmpresa.Key = key;
                return oEntityEmpresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa Update(EntityEmpresa oEntityEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(oEntityEmpresa, "empresa");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpresa Delete(EntityEmpresa oEntityEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataEmpresaRepository data = new DataEmpresaRepository(oEntityEmpresa, "empresa");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
