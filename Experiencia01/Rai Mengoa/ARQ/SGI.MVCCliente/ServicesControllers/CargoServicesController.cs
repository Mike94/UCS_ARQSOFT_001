using SGI.Proxy.Services.CargoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class CargoServicesController
    {
        private ICargoServices cargoService;

        public ICargoServices CargoService
        {
            get
            {
                return (null == cargoService) ?
                    new CargoServicesClient() : CargoService;
            }
            set { cargoService = value; }
        }

        public IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion)
        {
            try
            {
                using (CargoServicesClient oCargoServices = new CargoServicesClient())
                {
                    return oCargoServices.SelectPagging(ref oEntityCargoPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityCargo> Select(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoService.Select(oEntityCargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo SelectByKey(KeyCargo oKeyCargo)
        {
            try
            {
                return CargoService.SelectByKey(oKeyCargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Insert(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoService.Insert(oEntityCargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityCargo Update(EntityCargo oEntityCargo)
        {
            try
            {
                return CargoService.Update(oEntityCargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}