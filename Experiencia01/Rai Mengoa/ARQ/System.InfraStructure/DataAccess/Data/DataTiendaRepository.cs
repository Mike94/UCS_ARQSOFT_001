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
    public class DataTiendaRepository : BaseDataRepository<EntityTienda>
    {
        public DataTiendaRepository(EntityTienda oEntityTienda, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityTienda;
        }

        #region Sobreescritos para el data access

        public override EntityTienda Create(IDataReader oDataReader)
        {
            return EntityTienda.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("CodTienda", Entity.Key.CodTienda);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }
           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("CodTienda", Entity.Key.CodTienda);

            this.CollectionParams.AddInputParameter("NombreTienda", Entity.NombreTienda);
            this.CollectionParams.AddInputParameter("Direccion", Entity.Direccion);
            this.CollectionParams.AddInputParameter("IdDistrito", Entity.IdDistrito);
            this.CollectionParams.AddInputParameter("IdProvincia", Entity.IdProvincia);
            this.CollectionParams.AddInputParameter("IdRegion", Entity.IdRegion);
            this.CollectionParams.AddInputParameter("Referencia", Entity.Referencia);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("CodTienda", Entity.Key.CodTienda);

            this.CollectionParams.AddInputParameter("NombreTienda", Entity.NombreTienda);
            this.CollectionParams.AddInputParameter("Direccion", Entity.Direccion);
            this.CollectionParams.AddInputParameter("IdDistrito", Entity.IdDistrito);
            this.CollectionParams.AddInputParameter("IdProvincia", Entity.IdProvincia);
            this.CollectionParams.AddInputParameter("IdRegion", Entity.IdRegion);
            this.CollectionParams.AddInputParameter("Referencia", Entity.Referencia);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("CodTienda", Entity.Key.CodTienda);
        }

        #endregion

        public EntityTienda SelectByKey(KeyTienda okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("CodTienda", okey.CodTienda);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Tienda_Select))
            {
                if (reader.Read())
                {
                    return EntityTienda.Create(reader);
                }
            }

            return EntityTienda.Empty;
        }

        public IList<EntityTiendaPaginacion> SelectPagging(ref EntityTiendaPaginacion oEntityTiendaPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("CodTienda", oEntityTiendaPaginacion.Key.CodTienda);
            run.CollectionParams.AddInputParameter("Estado", oEntityTiendaPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityTiendaPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityTiendaPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityTiendaPaginacion> oListTienda = new List<EntityTiendaPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Tienda_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListTienda.Add(EntityTiendaPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityTiendaPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListTienda;
        }
    }
}
