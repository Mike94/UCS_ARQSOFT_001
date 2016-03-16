using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Repository;
using SGISystem.Helpers;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.InfraStructure.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.InfraStructure.Repositories
{
    public class TipoEmpresaRepository : ITipoEmpresaRepository
    {
        public IList<EntityTipoEmpresa> Select(EntityTipoEmpresa oEntityTipoEmpresa, CTransaction oCTransaction)
        {
            try
            {
                DataTipoEmpresaRepository data = new DataTipoEmpresaRepository(oEntityTipoEmpresa, "TipoEmpresa");
                return data.Select(oCTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EntityTipoEmpresa SelectByKey(KeyTipoEmpresa okey, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public IList<EntityTipoEmpresaPaginacion> SelectPagging(ref EntityTipoEmpresaPaginacion oValuePaginacion)
        {
            throw new NotImplementedException();
        }

        public EntityTipoEmpresa Insert(EntityTipoEmpresa oValue, CTransaction oCTransaction)
        {
            throw new NotImplementedException();
        }

        public EntityTipoEmpresa Update(EntityTipoEmpresa oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }

        public EntityTipoEmpresa Delete(EntityTipoEmpresa oValue, CTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
