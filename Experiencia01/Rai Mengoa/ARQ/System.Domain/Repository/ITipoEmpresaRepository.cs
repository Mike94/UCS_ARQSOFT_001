using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Domain.Repository
{
    public interface ITipoEmpresaRepository : IBaseRepository<KeyTipoEmpresa, EntityTipoEmpresa, EntityTipoEmpresaPaginacion>
    {
    }
}
