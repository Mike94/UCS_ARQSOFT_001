using SGI.Proxy.Services.UbigeoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class UbigeoServicesController
    {
        private IUbigeoServices ubigeoService;

        public IUbigeoServices UbigeoService
        {
            get
            {
                return (null == ubigeoService) ?
                    new UbigeoServicesClient() : UbigeoService;
            }
            set { ubigeoService = value; }
        }

        public IList<EntityDistrito> SelectDistrito(EntityDistrito oEntityDistrito)
        {
            try
            {
                return UbigeoService.SelectDistrito(oEntityDistrito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityProvincia> SelectProvincia(EntityProvincia oEntityProvincia)
        {
            try
            {
                return UbigeoService.SelectProvincia(oEntityProvincia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityDepartamento> SelectDepartamento(EntityDepartamento oEntityDepartamento)
        {
            try
            {
                return UbigeoService.SelectDepartamento(oEntityDepartamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}