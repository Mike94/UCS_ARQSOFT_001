using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application.Interfaces
{
    public interface ICargoApplication
    {
        EntityCargo Insert(EntityCargo oEntityCargo);
        EntityCargo Update(EntityCargo oEntityCargo);
        EntityCargo Delete(EntityCargo oEntityCargo);
        EntityCargo SelectByKey(KeyCargo oKeyCargo);
        IList<EntityCargo> Select(EntityCargo oEntityCargo);
        IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion);
    }
}
