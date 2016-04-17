using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.InfraStructure.Repositories
{
    public class DetallePedidoRepository : IDetallePedidoRepository
    {
        public EntityDetallePedido SelectByKey(KeyDetallePedido okey, CTransaction oCTransaction)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(EntityDetallePedido.Empty, "detalle_pedido");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityDetallePedido> Select(EntityDetallePedido oEntityDetallePedido, CTransaction oCTransaction)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(oEntityDetallePedido, "detalle_pedido");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(EntityDetallePedidoPaginacion.Empty, "detalle_pedido");
                return data.SelectPagging(ref oEntityDetallePedidoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Insert(EntityDetallePedido oEntityDetallePedido, CTransaction oCTransaction)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(oEntityDetallePedido, "detalle_pedido");
                return data.Insert(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Update(EntityDetallePedido oEntityDetallePedido, CTransaction oCTransaction)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(oEntityDetallePedido, "detalle_pedido");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Delete(EntityDetallePedido oEntityDetallePedido, CTransaction oCTransaction)
        {
            try
            {
                DataDetallePedidoRepository data = new DataDetallePedidoRepository(oEntityDetallePedido, "detalle_pedido");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
