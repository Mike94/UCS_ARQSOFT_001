using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application.Interfaces
{
    public interface ITiendaApplication
    {
        EntityTienda Insert(EntityTienda oEntityTienda);
        EntityTienda Update(EntityTienda oEntityTienda);
        EntityTienda Delete(EntityTienda oEntityTienda);
        EntityTienda SelectByKey(KeyTienda oKeyTienda);
        IList<EntityTienda> Select(EntityTienda oEntityTienda);
        IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion);
    }
}
