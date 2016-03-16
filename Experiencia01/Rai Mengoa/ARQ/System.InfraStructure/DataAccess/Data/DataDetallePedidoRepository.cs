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
    public class DataDetallePedidoRepository : BaseDataRepository<EntityDetallePedido>
    {
        public DataDetallePedidoRepository(EntityDetallePedido oEntityDetallePedido, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityDetallePedido;
        }

        #region Sobreescritos para el data access

        public override EntityDetallePedido Create(IDataReader oDataReader)
        {
            return EntityDetallePedido.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            this.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);
        }
           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            this.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);

            this.CollectionParams.AddInputParameter("Cantidad", Entity.Cantidad);
            this.CollectionParams.AddInputParameter("TotalBruto", Entity.TotalBruto);
            this.CollectionParams.AddInputParameter("Retencion", Entity.Retencion);
            this.CollectionParams.AddInputParameter("TotalNeto", Entity.TotalNeto);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            this.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);

            this.CollectionParams.AddInputParameter("Cantidad", Entity.Cantidad);
            this.CollectionParams.AddInputParameter("TotalBruto", Entity.TotalBruto);
            this.CollectionParams.AddInputParameter("Retencion", Entity.Retencion);
            this.CollectionParams.AddInputParameter("TotalNeto", Entity.TotalNeto);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            this.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);
        }

        #endregion

        public EntityDetallePedido SelectByKey(KeyDetallePedido okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            run.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.DetallePedido_Select))
            {
                if (reader.Read())
                {
                    return EntityDetallePedido.Create(reader);
                }
            }

            return EntityDetallePedido.Empty;
        }

        public IList<EntityDetallePedidoPaginacion> SelectPagging(ref EntityDetallePedidoPaginacion oEntityDetallePedidoPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDPedido", Entity.Key.IDPedido);
            run.CollectionParams.AddInputParameter("IDProducto", Entity.Key.IDProducto);

            run.CollectionParams.AddInputParameter("Estado", oEntityDetallePedidoPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityDetallePedidoPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityDetallePedidoPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityDetallePedidoPaginacion> oListDetallePedido = new List<EntityDetallePedidoPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.DetallePedido_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListDetallePedido.Add(EntityDetallePedidoPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityDetallePedidoPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListDetallePedido;
        }
    }
}
