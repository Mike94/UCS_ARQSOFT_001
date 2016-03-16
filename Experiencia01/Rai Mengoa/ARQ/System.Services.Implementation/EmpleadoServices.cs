using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;
using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Services.Contracts;
using System.ServiceModel;
using SGISystem.Domain.Entities.Keys;

namespace SGISystem.Services.Implementation
{
    public class EmpleadoServices : IEmpleadoServices
    {
        public EmpleadoServices()
        {
            _app = new EmpleadoApplication();
        }

        private IEmpleadoApplication _app;

        public IEmpleadoApplication EmployeeApp
        {
            get { return _app; }
            set { _app = value; }
        }


        public IList<EntityEmpleado> SelectTest()
        {
            try
            {
                return EmployeeApp.Select(EntityEmpleado.Empty);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar empleados");
            }
        }

        public EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado)
        {
            try
            {
                return EmployeeApp.SelectByKey(oKeyEmpleado);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar empleados");
            }
        }

        public IList<EntityEmpleado> Select(EntityEmpleado oEntityEmployee)
        {
            try
            {
                 return EmployeeApp.Select(oEntityEmployee);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar empleados");
            }
        }

        public IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmployeePaginacion)
        {
            try
            {
                return EmployeeApp.SelectPagging(ref oEntityEmployeePaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar empleados");
            }
        }

        public EntityEmpleado Insert(EntityEmpleado oEntityEmployee)
        {
            try
            {
                return EmployeeApp.Insert(oEntityEmployee);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar empleados");
            } 
        }


        public EntityEmpleado Update(EntityEmpleado oEntityEmployee)
        {
            try
            {
                return EmployeeApp.Update(oEntityEmployee);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar empleados");
            }
        }

        public EntityEmpleado Delete(EntityEmpleado oEntityEmployee)
        {
            try
            {
                return EmployeeApp.Delete(oEntityEmployee);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar empleados");
            }
        }
    }
}
