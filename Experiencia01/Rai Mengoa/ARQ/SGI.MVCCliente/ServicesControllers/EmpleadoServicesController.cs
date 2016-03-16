using SGI.Proxy.Services.EmpleadoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace SGI.MVCCliente.ServicesControllers
{
    public class EmpleadoServicesController
    {
        private IEmpleadoServices empleadoService;

        public IEmpleadoServices EmpleadoService
        {
            get
            {
                return (null == empleadoService) ?
                    new EmpleadoServicesClient() : empleadoService;
            }
            set { empleadoService = value; }
        }

        public IList<EntityEmpleadoPaginacion> SelectPagging(ref EntityEmpleadoPaginacion oEntityEmpleadoPaginacion)
        {
            try
            {
                using (EmpleadoServicesClient oEmpleadoServices = new EmpleadoServicesClient())
                {
                    return oEmpleadoServices.SelectPagging(ref oEntityEmpleadoPaginacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<EntityEmpleado> Select(EntityEmpleado oEntityEmpleado)
        {
            try
            {
                return EmpleadoService.Select(oEntityEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado SelectByKey(KeyEmpleado oKeyEmpleado)
        {
            try
            {
                return EmpleadoService.SelectByKey(oKeyEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Insert(EntityEmpleado oEntityEmpleado)
        {
            try
            {
                return EmpleadoService.Insert(oEntityEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityEmpleado Update(EntityEmpleado oEntityEmpleado)
        {
            try
            {
                return EmpleadoService.Update(oEntityEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}