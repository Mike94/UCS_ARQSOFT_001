using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application
{
    public class UsuarioApplication : IUsuarioApplication
    {
        public UsuarioApplication()
        {
            _repo = new UsuarioRepository();
        }

        private IUsuarioRepository _repo;

        public IUsuarioRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }
        public Boolean Autenticar(EntityUsuario oEntityUsuario)
        {
            try
            {
                return Repo.Autenticar(oEntityUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Insert(EntityUsuario oEntityUsuario)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityUsuario, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Update(EntityUsuario oEntityUsuario)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityUsuario, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario Delete(EntityUsuario oEntityUsuario)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityUsuario, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityUsuario SelectByKey(KeyUsuario oKeyUsuario)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyUsuario, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityUsuario> Select(EntityUsuario oEntityUsuario)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityUsuario, oCTransaction);
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
                return Repo.SelectPagging(ref oEntityUsuarioPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
