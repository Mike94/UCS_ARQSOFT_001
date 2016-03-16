using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IEmpleadoApplication 
    {
        EntityEmpleado Insert(EntityEmpleado oEntityEmployee);
        EntityEmpleado Update(EntityEmpleado oEntityEmployee);
        EntityEmpleado Delete(EntityEmpleado oEntityEmployee);
        EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado);
        IList<EntityEmpleado> Select(EntityEmpleado oEntityEmployee);
        IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmployeePaginacion);
    }
}
