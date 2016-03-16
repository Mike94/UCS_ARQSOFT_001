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
    public class DataEmpresaRepository : BaseDataRepository<EntityEmpresa> 
    {
        public DataEmpresaRepository(EntityEmpresa oEntityEmpresa, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityEmpresa;
        }

        #region Sobreescritos para el data access

        public override EntityEmpresa Create(IDataReader datareader)
        {
            return EntityEmpresa.Create(datareader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("CodigoEmpresa", Entity.CodigoEmpresa);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }
           
        protected override void OnInsert()
        {
            this.CollectionParams.AddInputParameter("CodigoEmpresa", Entity.CodigoEmpresa);
            this.CollectionParams.AddInputParameter("RazonComercial", Entity.RazonComercial);
            this.CollectionParams.AddInputParameter("RazonSocial", Entity.RazonSocial);
            this.CollectionParams.AddInputParameter("RUC", Entity.RUC);
            this.CollectionParams.AddInputParameter("Telefono", Entity.Telefono);
            this.CollectionParams.AddInputParameter("Contacto", Entity.Contacto);
            this.CollectionParams.AddInputParameter("Direccion", Entity.Direccion);
            this.CollectionParams.AddInputParameter("IdTipoEmpresa", Entity.IdTipoEmpresa);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);

            this.CollectionParams.AddOutputParameter("IDEmpresa");
        }

        protected override void OnUpdate()
        {
            this.CollectionParams.AddInputParameter("IDEmpresa", Entity.Key.IDEmpresa);

            this.CollectionParams.AddInputParameter("CodigoEmpresa", Entity.CodigoEmpresa);
            this.CollectionParams.AddInputParameter("RazonComercial", Entity.RazonComercial);
            this.CollectionParams.AddInputParameter("RazonSocial", Entity.RazonSocial);
            this.CollectionParams.AddInputParameter("RUC", Entity.RUC);
            this.CollectionParams.AddInputParameter("Telefono", Entity.Telefono);
            this.CollectionParams.AddInputParameter("Contacto", Entity.Contacto);
            this.CollectionParams.AddInputParameter("Direccion", Entity.Direccion);
            this.CollectionParams.AddInputParameter("IdTipoEmpresa", Entity.IdTipoEmpresa);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        protected override void OnDelete()
        {
            this.CollectionParams.AddInputParameter("IDEmpresa", Entity.Key.IDEmpresa);
        }

        #endregion

        public IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("CodigoEmpresa", oEntityEmpresaPaginacion.CodigoEmpresa);
            run.CollectionParams.AddInputParameter("Estado", oEntityEmpresaPaginacion.Estado);

            run.CollectionParams.AddInputParameter("PageIndex", oEntityEmpresaPaginacion.EntityPaginacion.PageIndex);
            run.CollectionParams.AddInputParameter("PageSize", oEntityEmpresaPaginacion.EntityPaginacion.RowsPerPage);

            run.CollectionParams.AddOutputParameter("TotalRows");


            IList<EntityEmpresaPaginacion> oListEmpresa = new List<EntityEmpresaPaginacion>();
            using (IDataReader reader = run.ExecuteReader(CTransaction.Empty, Procedimientos.Empresa_Select_Paginado))
            {
                
                while (reader.Read())
                {
                    oListEmpresa.Add(EntityEmpresaPaginacion.CreatePag(reader));
                }
            }
            run.AssignReturnParameters();

            oEntityEmpresaPaginacion.EntityPaginacion.RowCount = DataCreator.CreateInt32(run.CollectionParams.GetParameter("TotalRows").Value);

            return oListEmpresa;
        }

        public EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa, CTransaction oCTransaction)
        {
            DataProcedure run = new DataProcedure();

            run.CollectionParams.AddInputParameter("IDEmpresa", oKeyEmpresa.IDEmpresa);

            using (IDataReader reader = run.ExecuteReader(oCTransaction, Procedimientos.Empresa_Select))
            {
                if (reader.Read())
                {
                    return EntityEmpresa.Create(reader);
                }
            }

            return EntityEmpresa.Empty;
        }
    }
}
