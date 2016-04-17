using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using SGISystem.InfraStructure.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGISystem.Domain.Repository;
using SGISystem.Domain.Entities.Keys;

namespace SGISystem.Application.Application
{
   public  class ProductoApplication : IProductoApplication
    {
         public ProductoApplication()
        {
            _repo = new ProductoRepository();
        }

        private IProductoRepository  _repo;

        public IProductoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityProducto> Select(EntityProducto oEntityProducto)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityProducto, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public EntityProducto Insert(Domain.Entities.EntityProducto oEntityProducto)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityProducto, oCTransaction);
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
                return Repo.SelectPagging(ref oEntityProductoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityProducto SelectByKey(KeyProducto oKeyProducto)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyProducto, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        //public EntityProducto Update(EntityProducto oEntityProducto)
        //{
        //    try
        //    {
        //        CTransaction oCTransaction = CTransaction.Empty;
        //        return Repo.Update(oEntityProducto, oCTransaction);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public EntityProducto Update(Domain.Entities.EntityProducto oEntityProducto)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityProducto, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
