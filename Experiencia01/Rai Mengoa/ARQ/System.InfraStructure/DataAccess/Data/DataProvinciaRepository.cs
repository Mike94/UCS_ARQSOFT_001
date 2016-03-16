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
    public class DataProvinciaRepository : BaseDataRepository<EntityProvincia>
    {
        public DataProvinciaRepository(EntityProvincia oEntityProvincia, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityProvincia;
        }

        #region Sobreescritos para el data access

        public override EntityProvincia Create(IDataReader oDataReader)
        {
            return EntityProvincia.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IdDepartamento", Entity.Key.IdDepartamento);
            this.CollectionParams.AddInputParameter("IdProvincia", Entity.Key.IdProvincia);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        #endregion
    }
}