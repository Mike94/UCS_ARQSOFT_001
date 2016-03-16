using SGISystem.Domain.Entities;
using SGISystem.Helpers;
using SGISystem.Helpers.Constantes;
using SGISystem.Helpers.DataAccess;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataUsuarioRepository : BaseDataRepository<EntityUsuario>
    {
        public DataUsuarioRepository(EntityUsuario oEntityUsuario, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityUsuario;
        }

        #region Sobreescritos para el data access

        public override EntityUsuario Create(IDataReader oDataReader)
        {
            return EntityUsuario.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("Usuario", Entity.Usuario);
        }

           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("IDUsuario", Entity.Key.IDUsuario);

            this.CollectionParams.AddInputParameter("Usuario", Entity.Usuario);
            this.CollectionParams.AddInputParameter("Clave", Entity.Clave);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }


        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDUsuario", Entity.Key.IDUsuario);
            this.CollectionParams.AddInputParameter("Usuario", Entity.Usuario);
            this.CollectionParams.AddInputParameter("Clave", Entity.Clave);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDUsuario", Entity.Key.IDUsuario);
        }

        #endregion

        public Boolean Autenticar(EntityUsuario oEntityUsuario)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("Usuario", oEntityUsuario.Usuario);
            run.CollectionParams.AddInputParameter("Clave", oEntityUsuario.Clave);

            CTransaction oCTransaction = CTransaction.Empty;
            Boolean result = false;
            result = Convert.ToBoolean(run.ExecuteScalar(oCTransaction, Procedimientos.Usuario_Autenticar));

            return result;
        }

        public EntityUsuario SelectByKey(Domain.Entities.Keys.KeyUsuario okey, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDUsuario", okey.IDUsuario);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Usuario_Select))
            {

                if (reader.Read())
                {
                    return EntityUsuario.Create(reader);
                }
            }

            return EntityUsuario.Empty;
        }

        public IList<EntityUsuarioPaginacion> SelectPagging(ref EntityUsuarioPaginacion oEntityUsuarioPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("Usuario", oEntityUsuarioPaginacion.Usuario);
            run.CollectionParams.AddInputParameter("Estado", oEntityUsuarioPaginacion.Estado);
            run.CollectionParams.AddInputParameter("PageIndex", oEntityUsuarioPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityUsuarioPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityUsuarioPaginacion> oListUsuario = new List<EntityUsuarioPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Usuario_Select_Paginado))
            {

                while (reader.Read())
                {
                    oListUsuario.Add(EntityUsuarioPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityUsuarioPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListUsuario;
        }
    }
}