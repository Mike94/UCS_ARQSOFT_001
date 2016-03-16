using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;
using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Services.Contracts;
using System.ServiceModel;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;

namespace SGISystem.Services.Implementation
{
    public class PedidoServices : IPedidoServices
    {
        public PedidoServices()
        {
            _app = new PedidoApplication();
        }

        private IPedidoApplication _app;

        public IPedidoApplication PedidoApp
        {
            get { return _app; }
            set { _app = value; }
        }

        public EntityPedido SelectByKey(KeyPedido oKeyPedido)
        {
            try
            {
                return PedidoApp.SelectByKey(oKeyPedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Pedidos");
            }
        }

        public IList<EntityPedido> Select(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoApp.Select(oEntityPedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Pedidos");
            }
        }

        public IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion)
        {
            try
            {
                return PedidoApp.SelectPagging(ref oEntityPedidoPaginacion);
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Pedidos");
            }
        }

        public EntityPedido Insert(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoApp.Insert(oEntityPedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Pedidos");
            }
        }

        public EntityPedido Update(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoApp.Update(oEntityPedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al actualizar Pedidos");
            }
        }

        public EntityPedido Delete(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoApp.Delete(oEntityPedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al eliminar Pedidos");
            }
        }


        public Int32 InsertPedidoCompleto(EntityPedido oEntityPedido, List<EntityDetallePedido> oListDetallePedido)
        {
            try
            {
                return PedidoApp.InsertPedidoCompleto(oEntityPedido, oListDetallePedido);
            }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Pedidos");
            }
        }
    }
}
