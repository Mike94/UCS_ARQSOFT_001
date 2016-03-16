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
    public interface ITipoEmpresaApplication
    {
        IList<EntityTipoEmpresa> Select(EntityTipoEmpresa oEntityTipoEmpresa);
    }
}
