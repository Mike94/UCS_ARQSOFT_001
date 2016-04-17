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
    public class EmpleadoRepository : IEmpleadoRepository
    {

        public EntityEmpleado SelectByKey(KeyEmpleado okey, CTransaction oCTransaction)
        {
            try
            {
                DataEmpleadoRepository data = new DataEmpleadoRepository(EntityEmpleado.Empty, "empleado");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityEmpleado> Select(EntityEmpleado oEntityEmployee, CTransaction oCTransaction)
        {
            try
            {
                DataEmpleadoRepository data = new DataEmpleadoRepository(oEntityEmployee , "empleado");
                return data.Select(oCTransaction);
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
                DataEmpleadoRepository data = new DataEmpleadoRepository(EntityEmpleado.Empty, "empleado");
                return data.SelectPagging(ref oEntityEmployeePaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Insert(EntityEmpleado entity, CTransaction transaction)
        {
            try
            {
                DataEmpleadoRepository data = new DataEmpleadoRepository(entity, "empleado");
                
               entity = data.Insert(transaction);
               KeyEmpleado key = new KeyEmpleado(DataCreator.CreateInt32(data.CollectionParams.GetParameter("IDEmpleado").Value));
               entity.Key = key;
               return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Update(EntityEmpleado entity, CTransaction transaction)
        {
            try
            {
                DataEmpleadoRepository data = new DataEmpleadoRepository(entity, "empleado");
                entity = data.Update(transaction);
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Delete(EntityEmpleado entity, CTransaction transaction)
        {
            try
            {
                DataEmpleadoRepository data = new DataEmpleadoRepository(entity, "empleado");
                entity = data.Delete(transaction);
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
