using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGISystem.Helpers.DataAccess.Transactions;
using SGISystem.Domain.Entities.Pagination;


namespace SGISystem.Domain.Repository
{
    public interface IGrupoRepository : IBaseRepository<KeyGrupo, EntityGrupo, EntityGrupoPaginacion>
    {

    }
}
