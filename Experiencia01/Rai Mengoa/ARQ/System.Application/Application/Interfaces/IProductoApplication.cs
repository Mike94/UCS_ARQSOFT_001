using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IProductoApplication
    {
        IList<EntityProducto> Select(EntityProducto oEntityProducto);
        EntityProducto Insert(EntityProducto oEntityProducto);
        EntityProducto SelectByKey(KeyProducto oKeyProducto);
        IList<EntityProductoPaginacion> SelectPagging(ref EntityProductoPaginacion oEntityProductoPaginacion);

        EntityProducto Update(EntityProducto oEntityProducto);
    }
}
