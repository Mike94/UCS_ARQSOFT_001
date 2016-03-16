using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using SGISystem.Helpers.DataAccess;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataPedidoRepository : BaseDataRepository<EntityPedido>
    {
        public DataPedidoRepository(EntityPedido oEntityPedido, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityPedido;
        }

        #region Sobreescritos para el data access

        public override EntityPedido Create(IDataReader oDataReader)
        {
            return EntityPedido.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
        }
           
        protected override void OnInsert()
        {
            this.CollectionParams.AddOutputParameter("IDPedido");

            this.CollectionParams.AddInputParameter("IDEmpresa", Entity.IDEmpresa);
            this.CollectionParams.AddInputParameter("CodigoPedido", Entity.CodigoPedido);
            this.CollectionParams.AddInputParameter("FechaPedido", Entity.FechaPedido);
            this.CollectionParams.AddInputParameter("FechaPago", Entity.FechaPago);
            this.CollectionParams.AddInputParameter("FechaEntrega", Entity.FechaEntrega);
            this.CollectionParams.AddInputParameter("IDEncargado", Entity.IDEncargado);
            this.CollectionParams.AddInputParameter("TotalBruto", Entity.TotalBruto);
            this.CollectionParams.AddInputParameter("Retencion", Entity.Retencion);
            this.CollectionParams.AddInputParameter("TotalNeto", Entity.TotalNeto);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);

            this.CollectionParams.AddInputParameter("IDEmpresa", Entity.IDEmpresa);
            this.CollectionParams.AddInputParameter("CodigoPedido", Entity.CodigoPedido);
            this.CollectionParams.AddInputParameter("FechaPedido", Entity.FechaPedido);
            this.CollectionParams.AddInputParameter("FechaPago", Entity.FechaPago);
            this.CollectionParams.AddInputParameter("FechaEntrega", Entity.FechaEntrega);
            this.CollectionParams.AddInputParameter("IDEncargado", Entity.IDEncargado);
            this.CollectionParams.AddInputParameter("TotalBruto", Entity.TotalBruto);
            this.CollectionParams.AddInputParameter("Retencion", Entity.Retencion);
            this.CollectionParams.AddInputParameter("TotalNeto", Entity.TotalNeto);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
        }

        #endregion

        public EntityPedido SelectByKey(KeyPedido okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDPedido", okey.IDPedido);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Pedido_Select))
            {
                if (reader.Read())
                {
                    return EntityPedido.Create(reader);
                }
            }

            return EntityPedido.Empty;
        }

        public IList<EntityPedidoPaginacion> SelectPagging(ref EntityPedidoPaginacion oEntityPedidoPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("CodigoPedido", oEntityPedidoPaginacion.CodigoPedido);
            run.CollectionParams.AddInputParameter("Estado", oEntityPedidoPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityPedidoPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityPedidoPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityPedidoPaginacion> oListPedido = new List<EntityPedidoPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Pedido_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListPedido.Add(EntityPedidoPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityPedidoPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListPedido;
        }
    }
}
