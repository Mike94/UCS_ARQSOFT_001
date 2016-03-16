using SGI.Proxy.Services.PedidoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class PedidoServicesController
    {
        private IPedidoServices pedidoService;

        public IPedidoServices PedidoService
        {
            get
            {
                return (null == pedidoService) ?
                    new PedidoServicesClient() : PedidoService;
            }
            set { pedidoService = value; }
        }

        public IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion)
        {
            try
            {
                using (PedidoServicesClient oPedidoServices = new PedidoServicesClient())
                {
                    return oPedidoServices.SelectPagging(ref oEntityPedidoPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityPedido> Select(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoService.Select(oEntityPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido SelectByKey(KeyPedido oKeyPedido)
        {
            try
            {
                return PedidoService.SelectByKey(oKeyPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Insert(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoService.Insert(oEntityPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 InsertPedidoCompleto(EntityPedido oEntityPedido, IList<EntityDetallePedido> oListDetallePedido)
        {
            try
            {
                return PedidoService.InsertPedidoCompleto(oEntityPedido, oListDetallePedido.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Update(EntityPedido oEntityPedido)
        {
            try
            {
                return PedidoService.Update(oEntityPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}