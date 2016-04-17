using System;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;

namespace SGISystem.Domain.Repository
{
    public interface IDetallePedidoRepository : IBaseRepository<KeyDetallePedido, EntityDetallePedido, EntityDetallePedidoPaginacion>
    {

    }
}
