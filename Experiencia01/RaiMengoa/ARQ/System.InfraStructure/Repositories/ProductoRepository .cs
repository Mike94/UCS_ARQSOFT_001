using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.InfraStructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        public IList<EntityProducto> Select(EntityProducto oEntityProducto, CTransaction oCTransaction)
        {
            try
            {
                DataProductoRepository data = new DataProductoRepository(oEntityProducto, "producto");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EntityProducto Insert(EntityProducto entity, CTransaction transaction)
        {
            try
            {
                DataProductoRepository data = new DataProductoRepository(entity, "producto");

                entity = data.Insert(transaction);
                KeyProducto key = new KeyProducto(DataCreator.CreateInt32(data.CollectionParams.GetParameter("IDProducto").Value));
                entity.Key = key;
                return entity;
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
                DataProductoRepository data = new DataProductoRepository(EntityProducto.Empty, "producto");
                return data.SelectPagging(ref oEntityProductoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityProducto SelectByKey(KeyProducto okey, CTransaction oCTransaction)
        {
            try
            {
                DataProductoRepository data = new DataProductoRepository(EntityProducto.Empty, "producto");
                return data.SelectByKey(okey, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        public EntityProducto Update(EntityProducto oEntityProducto, CTransaction transaction)
        {
            try
            {
                DataProductoRepository data = new DataProductoRepository(oEntityProducto, "producto");
                return data.Update(transaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityProducto Delete(EntityProducto oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
