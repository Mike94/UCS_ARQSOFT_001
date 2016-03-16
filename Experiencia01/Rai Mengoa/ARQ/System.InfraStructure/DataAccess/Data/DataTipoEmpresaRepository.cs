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
    public class DataTipoEmpresaRepository : BaseDataRepository<EntityTipoEmpresa>
    {
        public DataTipoEmpresaRepository(EntityTipoEmpresa oEntityTipoEmpresa, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityTipoEmpresa;
        }

        #region Sobreescritos para el data access

        public override EntityTipoEmpresa Create(IDataReader oDataReader)
        {
            return EntityTipoEmpresa.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IDTipoEmpresa", Entity.Key.IDTipoEmpresa);
            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        #endregion

    }
}
