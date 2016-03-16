using SGI.Proxy.Services.TiendaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class TiendaServicesController
    {
        private ITiendaServices tiendaService;

        public ITiendaServices TiendaService
        {
            get
            {
                return (null == tiendaService) ?
                    new TiendaServicesClient() : TiendaService;
            }
            set { tiendaService = value; }
        }

        public IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion)
        {
            try
            {
                using (TiendaServicesClient oTiendaServices = new TiendaServicesClient())
                {
                    return oTiendaServices.SelectPagging(ref oEntityTiendaPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityTienda> Select(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaService.Select(oEntityTienda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda SelectByKey(KeyTienda oKeyTienda)
        {
            try
            {
                return TiendaService.SelectByKey(oKeyTienda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Insert(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaService.Insert(oEntityTienda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTienda Update(EntityTienda oEntityTienda)
        {
            try
            {
                return TiendaService.Update(oEntityTienda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}