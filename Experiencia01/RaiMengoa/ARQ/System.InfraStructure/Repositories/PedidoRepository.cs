using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.InfraStructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public EntityPedido SelectByKey(KeyPedido okey, CTransaction oCTransaction)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(EntityPedido.Empty, "pedido");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityPedido> Select(EntityPedido oEntityPedido, CTransaction oCTransaction)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(oEntityPedido, "pedido");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(EntityPedidoPaginacion.Empty, "pedido");
                return data.SelectPagging(ref oEntityPedidoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Insert(EntityPedido oEntityPedido, CTransaction oCTransaction)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(oEntityPedido, "pedido");
                oEntityPedido = data.Insert(oCTransaction);
                KeyPedido key = new KeyPedido(DataCreator.CreateInt32(data.CollectionParams.GetParameter("IDPedido").Value));
                oEntityPedido.Key = key;
                return oEntityPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Update(EntityPedido oEntityPedido, CTransaction oCTransaction)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(oEntityPedido, "pedido");
                return data.Update(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Delete(EntityPedido oEntityPedido, CTransaction oCTransaction)
        {
            try
            {
                DataPedidoRepository data = new DataPedidoRepository(oEntityPedido, "pedido");
                return data.Delete(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
