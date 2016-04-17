using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IDetallePedidoApplication
    {
        EntityDetallePedido Insert(EntityDetallePedido oEntityDetallePedido);
        EntityDetallePedido Update(EntityDetallePedido oEntityDetallePedido);
        EntityDetallePedido Delete(EntityDetallePedido oEntityDetallePedido);
        EntityDetallePedido SelectByKey(KeyDetallePedido oKeyDetallePedido);
        IList<EntityDetallePedido> Select(EntityDetallePedido oEntityDetallePedido);
        IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion);
    }
}
