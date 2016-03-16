using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IDepartamentoApplication
    {
        IList<EntityDepartamento> Select(EntityDepartamento oEntityDepartamento);
    }
}
