using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using SGISystem.Helpers.DataAccess;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataProductoRepository : BaseDataRepository<EntityProducto>
    {
        public DataProductoRepository(EntityProducto oEntityProducto, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityProducto;
        }

        #region Sobreescritos para el data access

        public override EntityProducto Create(IDataReader oDataReader)
        {
            return EntityProducto.Create(oDataReader);
        }
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("NombreProducto", Entity.Nombre);
            this.CollectionParams.AddInputParameter("DescripcionCorta", Entity.DescripcionCorta );
            this.CollectionParams.AddInputParameter("DescripcionLarga", Entity.DescripcionLarga);
            this.CollectionParams.AddInputParameter("CantidadMinimainventario", Entity.CantidadMinimaInventario);
            this.CollectionParams.AddInputParameter("CantidadInventario", Entity.Cantidadinventario);
            this.CollectionParams.AddInputParameter("PrecioUnitario", Entity.PrecioUnitario);
            this.CollectionParams.AddInputParameter("IdGrupo", Entity.IdGrupo);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);

            this.CollectionParams.AddOutputParameter("IDProducto");
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IdProducto", Entity.Key.IDProducto );

            this.CollectionParams.AddInputParameter("NombreProducto", Entity.Nombre);
            this.CollectionParams.AddInputParameter("DescripcionCorta", Entity.DescripcionCorta);
            this.CollectionParams.AddInputParameter("DescripcionLarga", Entity.DescripcionLarga);
            this.CollectionParams.AddInputParameter("CantidadMinimainventario", Entity.CantidadMinimaInventario);
            this.CollectionParams.AddInputParameter("CantidadInventario", Entity.Cantidadinventario);
            this.CollectionParams.AddInputParameter("PrecioUnitario", Entity.PrecioUnitario);
            this.CollectionParams.AddInputParameter("IdGrupo", Entity.IdGrupo);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IdProducto", Entity.Key.IDProducto);
        }

        public IList<EntityProductoPaginacion> SelectPagging(ref EntityProductoPaginacion oEntityProductoPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("NombreProducto", oEntityProductoPaginacion.Nombre);
            run.CollectionParams.AddInputParameter("IdGrupo", oEntityProductoPaginacion.IdGrupo);
            run.CollectionParams.AddInputParameter("Estado", oEntityProductoPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityProductoPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityProductoPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");
            

            IList<EntityProductoPaginacion> oListProducto = new List<EntityProductoPaginacion>();
           
                using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Producto_Select_Paginado))
                {
                    while (reader.Read())
                    {
                        oListProducto.Add(EntityProductoPaginacion.CreatePag(reader));
                    }
                }

           
           
            run.AssignReturnParameters();

            oEntityProductoPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListProducto;
        }

        public EntityProducto SelectByKey(KeyProducto okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDProducto", okey.IDProducto);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Producto_Select))
            {
                if (reader.Read())
                {
                    return EntityProducto.Create(reader);
                }
            }

            return EntityProducto.Empty;
        }
        //public IList<EntityGrupo> ListaGrupo()
        //{
        //    DataProcedure run = new DataProcedure();

        //    IList<EntityGrupo> oListGrupo = new List<EntityGrupo>();

        //    using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Producto_Select_Grupo))
        //    {
        //        while (reader.Read())
        //        {
        //            oListGrupo.Add(EntityGrupo.listar(reader));
        //        }
        //    }

        //    return oListGrupo;
        //}


        #endregion
    }
}
