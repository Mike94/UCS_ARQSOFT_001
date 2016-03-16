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
    public class EmpleadoApplication : IEmpleadoApplication
    {
        public EmpleadoApplication()
        {
            _repo = new EmpleadoRepository();
        }

        private IEmpleadoRepository _repo;

        public IEmpleadoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityEmpleado> Select(EntityEmpleado oEntityEmployee)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityEmployee, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmployeePaginacion)
        {
            try
            {
                return Repo.SelectPagging(ref oEntityEmployeePaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Insert(EntityEmpleado oEntityEmployee)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityEmployee, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Update(Domain.Entities.EntityEmpleado oEntityEmployee)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityEmployee, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Delete(Domain.Entities.EntityEmpleado oEntityEmployee)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityEmployee, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyEmpleado, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
