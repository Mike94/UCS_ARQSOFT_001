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

namespace SGISystem.InfraStructure.DataAccess.Data
{
    public class DataDepartamentoRepository : BaseDataRepository<EntityDepartamento>
    {
        public DataDepartamentoRepository(EntityDepartamento oEntityDepartamento, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityDepartamento;
        }

        #region Sobreescritos para el data access

        public override EntityDepartamento Create(IDataReader oDataReader)
        {
            return EntityDepartamento.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IdDepartamento", Entity.Key.IdDepartamento);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        #endregion
    }
}
