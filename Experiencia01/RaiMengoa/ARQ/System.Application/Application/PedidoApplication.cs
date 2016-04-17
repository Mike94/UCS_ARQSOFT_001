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
    public class PedidoApplication : IPedidoApplication
    {
        public PedidoApplication()
        {
            _repo = new PedidoRepository();
            _repo_detalle = new DetallePedidoRepository();
        }

        private IPedidoRepository _repo;
        private IDetallePedidoRepository _repo_detalle;

        public IPedidoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IDetallePedidoRepository RepoDetalle
        {
            get { return _repo_detalle; }
            set { _repo_detalle = value; }
        }

        public IList<EntityPedido> Select(EntityPedido oEntityPedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityPedido, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion)
        {
            try
            {
                return Repo.SelectPagging(ref oEntityPedidoPaginacion);
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
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Insert(oEntityPedido, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Update(Domain.Entities.EntityPedido oEntityPedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Update(oEntityPedido, oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityPedido Delete(Domain.Entities.EntityPedido oEntityPedido)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Delete(oEntityPedido, oCTransaction);
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
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.SelectByKey(oKeyPedido, oCTransaction);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Int32 InsertPedidoCompleto(EntityPedido oEntityPedido, List<EntityDetallePedido> oListDetallePedido)
        {
            CTransaction oCTransaction = CTransaction.Full;
            try
            {
                oEntityPedido = Repo.Insert(oEntityPedido, oCTransaction);
                foreach (EntityDetallePedido oEntityDetallePedido in oListDetallePedido)
	            {
		            oEntityDetallePedido.Key.IDPedido = oEntityPedido.Key.IDPedido;
                    RepoDetalle.Insert(oEntityDetallePedido, oCTransaction);
	            }

                oCTransaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                oCTransaction.RollBack();
                throw ex;
            }
        }
    }
}
