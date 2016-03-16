using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGISystem.Application.Application
{
    public class DetallePedidoApplication : IDetallePedidoApplication
    {
        public DetallePedidoApplication()
        {
            _repo = new DetallePedidoRepository();
        }

        private IDetallePedidoRepository _repo;

        public IDetallePedidoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityDetallePedido> Select(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityDetallePedido, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion)
        {
            try
            {
                return Repo.SelectPagging(ref oEntityDetallePedidoPaginacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Insert(EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityDetallePedido, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Update(Domain.Entities.EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityDetallePedido, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityDetallePedido Delete(Domain.Entities.EntityDetallePedido oEntityDetallePedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityDetallePedido, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public EntityDetallePedido SelectByKey(KeyDetallePedido oKeyDetallePedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyDetallePedido, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
