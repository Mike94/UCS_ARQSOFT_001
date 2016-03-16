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
    public class DataCargoRepository : BaseDataRepository<EntityCargo>
    {
        public DataCargoRepository(EntityCargo oEntityCargo, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityCargo;
        }

        #region Sobreescritos para el data access

        public override EntityCargo Create(IDataReader oDataReader)
        {
            return EntityCargo.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDCargo", Entity.Key.IDCargo);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }
           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("NombreCargo", Entity.NombreCargo);
            this.CollectionParams.AddInputParameter("Descripcion", Entity.Descripcion);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);

            this.CollectionParams.AddOutputParameter("IDCargo");
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDCargo", Entity.Key.IDCargo);
            this.CollectionParams.AddInputParameter("NombreCargo", Entity.NombreCargo);
            this.CollectionParams.AddInputParameter("Descripcion", Entity.Descripcion);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDCargo", Entity.Key.IDCargo);
        }

        #endregion

        public EntityCargo SelectByKey(KeyCargo okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDCargo", okey.IDCargo);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Cargo_Select))
            {
                if (reader.Read())
                {
                    return EntityCargo.Create(reader);
                }
            }

            return EntityCargo.Empty;
        }

        public IList<EntityCargoPaginacion> SelectPagging(ref EntityCargoPaginacion oEntityCargoPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("NombreCargo", oEntityCargoPaginacion.NombreCargo);
            run.CollectionParams.AddInputParameter("Estado", oEntityCargoPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityCargoPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityCargoPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityCargoPaginacion> oListCargo = new List<EntityCargoPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Cargo_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListCargo.Add(EntityCargoPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityCargoPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListCargo;
        }
    }
}
