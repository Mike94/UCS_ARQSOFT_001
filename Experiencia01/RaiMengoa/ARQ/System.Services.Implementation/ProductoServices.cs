using SGISystem.Application.Application;
using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace SGISystem.Services.Implementation
{
    public class ProductoServices : IProductoServices
    {
         public ProductoServices()
        {
            _app = new ProductoApplication();
        }

        private IProductoApplication _app;

        public IProductoApplication ProductooApp
        {
            get { return _app; }
            set { _app = value; }
        }
       public IList<EntityProducto> Select()
       {
           try
           {
               return ProductooApp.Select(EntityProducto.Empty);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public EntityProducto Insert(EntityProducto oEntityProducto)
       {
           try
           {
               return ProductooApp.Insert(oEntityProducto);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public IList<EntityProductoPaginacion> SelectPagging(ref EntityProductoPaginacion oEntityProductoPaginacion)
       {
           try
           {
               return ProductooApp.SelectPagging(ref oEntityProductoPaginacion);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public IList<EntityProducto> Select(EntityProducto oEntityProducto)
       {
           try
           {
               return ProductooApp.Select(oEntityProducto);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public EntityProducto SelectByKey(Domain.Entities.Keys.KeyProducto oKeyProducto)
       {
           try
           {
               return ProductooApp.SelectByKey(oKeyProducto);
           }
           catch (Exception)
           {
               throw new FaultException("Error al seleccionar Producto");
           }
       }


       public EntityProducto Update(EntityProducto oEntityProducto)
       {
           try
           {
               return ProductooApp.Update(oEntityProducto);
           }
           catch (Exception)
           {
               throw new FaultException("Error al actualizar Productos");
           }
       }
    }
}
