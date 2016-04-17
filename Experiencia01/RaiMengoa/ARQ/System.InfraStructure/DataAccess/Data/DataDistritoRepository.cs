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
    public class DataDistritoRepository : BaseDataRepository<EntityDistrito>
    {
        public DataDistritoRepository(EntityDistrito oEntityDistrito, String nameSP)
            : base(nameSP)
        {
            this.Entity = oEntityDistrito;
        }

        #region Sobreescritos para el data access

        public override EntityDistrito Create(IDataReader oDataReader)
        {
            return EntityDistrito.Create(oDataReader);
        }

        protected override void OnSelect()
        {
            this.CollectionParams.AddInputParameter("IdDepartamento", Entity.Key.IdDepartamento);
            this.CollectionParams.AddInputParameter("IdProvincia", Entity.Key.IdProvincia); 
            this.CollectionParams.AddInputParameter("IdDistrito", Entity.Key.IdDistrito);

            this.CollectionParams.AddInputParameter("Estado", Entity.Estado);
        }

        #endregion
    }
}