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
    public class UsuarioRepository : IUsuarioRepository
    {
        public Boolean Autenticar(EntityUsuario oEntityUsuario)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(oEntityUsuario, "usuario");
                return data.Autenticar(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Insert(EntityUsuario oEntityUsuario, CTransaction oCTransaction)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(oEntityUsuario, "usuario");
                return data.Insert(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Update(EntityUsuario oEntityUsuario, CTransaction oCTransaction)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(oEntityUsuario, "usuario");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Delete(EntityUsuario oEntityUsuario, CTransaction oCTransaction)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(oEntityUsuario, "usuario");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario SelectByKey(KeyUsuario okey, CTransaction oCTransaction)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(EntityUsuario.Empty, "usuario");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityUsuario> Select(EntityUsuario oEntityUsuario, CTransaction oCTransaction)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(oEntityUsuario, "usuario");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityUsuarioPaginacion> SelectPagging(ref EntityUsuarioPaginacion oEntityUsuarioPaginacion)
        {
            try
            {
                DataUsuarioRepository data = new DataUsuarioRepository(EntityUsuario.Empty, "usuario");
                return data.SelectPagging(ref oEntityUsuarioPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
