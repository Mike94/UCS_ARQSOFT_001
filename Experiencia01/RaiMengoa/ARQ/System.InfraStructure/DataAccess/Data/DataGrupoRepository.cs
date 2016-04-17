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
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataGrupoRepository : BaseDataRepository<EntityGrupo>
    {
        public DataGrupoRepository(EntityGrupo oEntityGrupo, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityGrupo;
        }

        #region Sobreescritos para el data access

        public override EntityGrupo Create(IDataReader oDataReader)
        {
            return EntityGrupo.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDGrupo", Entity.Key.IDGrupo);
        }
           
        protected override void OnInsert()
        {
            if (Entity.IDGrupoPadre == Parameters.UnoNegativo || Entity.IDGrupoPadre == Parameters.Cero)
            {
                this.CollectionParams.AddInputParameter("IDGrupoPadre", DBNull.Value, DbType.Int32);
            }
            else
            {
                this.CollectionParams.AddInputParameter("IDGrupoPadre", Entity.IDGrupoPadre);
            }
            
            this.CollectionParams.AddInputParameter("DescripcionCorta", Entity.DescripcionCorta);
            this.CollectionParams.AddInputParameter("DescripcionLarga", Entity.DescripcionLarga);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);

            this.CollectionParams.AddOutputParameter("IDGrupo");
        }

        protected override void OnUpdate()
        {

            this.CollectionParams.AddInputParameter("IDGrupo", Entity.Key.IDGrupo);

            if (Entity.IDGrupoPadre == Parameters.UnoNegativo || Entity.IDGrupoPadre == Parameters.Cero)
            {
                this.CollectionParams.AddInputParameter("IDGrupoPadre", DBNull.Value, DbType.Int32);
            }
            else
            {
                this.CollectionParams.AddInputParameter("IDGrupoPadre", Entity.IDGrupoPadre);
            }

            this.CollectionParams.AddInputParameter("DescripcionCorta", Entity.DescripcionCorta);
            this.CollectionParams.AddInputParameter("DescripcionLarga", Entity.DescripcionLarga);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDGrupo", Entity.Key.IDGrupo);
        }

        #endregion

        public EntityGrupo SelectByKey(KeyGrupo okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDGrupo", okey.IDGrupo);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Grupo_Select))
            {
                if (reader.Read())
                {
                    return EntityGrupo.Create(reader);
                }
            }

            return EntityGrupo.Empty;
        }

        public IList<EntityGrupoPaginacion> SelectPagging(ref EntityGrupoPaginacion oEntityGrupoPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("DescripcionCorta", oEntityGrupoPaginacion.DescripcionCorta);
            run.CollectionParams.AddInputParameter("Estado", oEntityGrupoPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityGrupoPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityGrupoPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityGrupoPaginacion> oListGrupo = new List<EntityGrupoPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Grupo_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListGrupo.Add(EntityGrupoPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityGrupoPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListGrupo;
        }
    }
}
