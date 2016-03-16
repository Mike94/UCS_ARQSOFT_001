using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Application.Application
{
    public class EmpresaApplication : IEmpresaApplication
    {
        public EmpresaApplication()
        {
            _repo = new EmpresaRepository();
        }

        private IEmpresaRepository _repo;

        public IEmpresaRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityEmpresa, oCTransaction);
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
                return Repo.SelectPagging(ref oEntityEmpresaPaginacion);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public EntityEmpresa Insert(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityEmpresa, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public EntityEmpresa Update(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityEmpresa, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public EntityEmpresa Delete(EntityEmpresa oEntityEmpresa)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityEmpresa, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public EntityEmpresa SelectByKey(Domain.Entities.Keys.KeyEmpresa oKeyEmpresa)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyEmpresa, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
