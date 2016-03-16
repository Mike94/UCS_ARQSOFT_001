using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IPedidoApplication
    {
        Int32 InsertPedidoCompleto(EntityPedido oEntityPedido, List<EntityDetallePedido> oListDetallePedido);
        EntityPedido Insert(EntityPedido oEntityPedido);
        EntityPedido Update(EntityPedido oEntityPedido);
        EntityPedido Delete(EntityPedido oEntityPedido);
        EntityPedido SelectByKey(KeyPedido oKeyPedido);
        IList<EntityPedido> Select(EntityPedido oEntityPedido);
        IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion);
    }
}
