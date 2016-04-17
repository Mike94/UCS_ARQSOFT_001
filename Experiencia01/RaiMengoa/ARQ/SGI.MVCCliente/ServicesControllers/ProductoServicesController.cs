using SGI.MVCCliente.ViewModel;
using SGI.Proxy.Services.GrupoServices;
using SGI.Proxy.Services.ProductoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using GrupoServices = SGI.Proxy.Services.GrupoServices;
using ProductoServices = SGI.Proxy.Services.ProductoServices;

namespace SGI.MVCCliente.ServicesControllers
{
    public class ProductoServicesController
    {

        public IList<EntityGrupo> Select(GrupoServices.EntityGrupo oEntityGrupo)
        {
            try
            {
                using (GrupoServices.GrupoServicesClient oGrupoServices = new GrupoServices.GrupoServicesClient())
                {
                    return oGrupoServices.Select(oEntityGrupo);
                }
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Grupo");
            }

        }
        public IList<EntityProducto> SelectProducto(ProductoServices.EntityProducto oEntityProducto)
        {
            try
            {
                using (ProductoServices.ProductoServicesClient oProductoServices = new ProductoServices.ProductoServicesClient())
                {
                    return oProductoServices.Select();
                }
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Producto");
            }

        }


        public EntityProducto AgregarProducto(EntityProducto oEntityEmploye)
        {
            try
            {
            using (ProductoServices.ProductoServicesClient client = new ProductoServices.ProductoServicesClient())
            {
                return client.Insert(oEntityEmploye);
            }
             }
            catch (Exception)
            {
                throw new FaultException("Error al insertar Producto");
            }


        }
        public IList<EntityProductoPaginacion> SelectPagging(ref EntityProductoPaginacion oEntityProductoPaginacion)
        {
            try
            {
                using (ProductoServices.ProductoServicesClient oProductoServices = new ProductoServices.ProductoServicesClient())
                {
                    return oProductoServices.SelectPagging(ref oEntityProductoPaginacion);
                }
            }
            catch (Exception)
            {
                throw new FaultException("Error al seleccionar Producto");
            }
        }
        public EntityProducto SelectByKey(KeyProducto oKeyProducto)
        {
            try
            {
                using (ProductoServices.ProductoServicesClient oGrupoServices = new ProductoServices.ProductoServicesClient())
                {
                    return oGrupoServices.SelectByKey(oKeyProducto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityProducto Update(EntityProducto oEntityProducto)
        {
            try
            {
                 using (ProductoServices.ProductoServicesClient oProducto = new ProductoServices.ProductoServicesClient())
                {
                    return oProducto.Update(oEntityProducto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     
    }
}