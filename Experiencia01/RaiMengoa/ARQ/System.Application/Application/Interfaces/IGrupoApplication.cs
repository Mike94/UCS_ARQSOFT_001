using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IGrupoApplication
    {
        EntityGrupo Insert(EntityGrupo oEntityGrupo);
        EntityGrupo Update(EntityGrupo oEntityGrupo);
        EntityGrupo Delete(EntityGrupo oEntityGrupo);
        EntityGrupo SelectByKey(KeyGrupo oKeyGrupo);
        IList<EntityGrupo> Select(EntityGrupo oEntityGrupo);
        IList<EntityGrupoPaginacion> SelectPagging(ref EntityGrupoPaginacion oEntityGrupoPaginacion);
    }
}
