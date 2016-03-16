using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Domain.Entities.Pagination;
using System;
using System.Collections.Generic;

namespace SGISystem.Domain.Repository
{
    public interface IProvinciaRepository : IBaseRepository<KeyProvincia, EntityProvincia, EntityProvinciaPaginacion>
    {
        
    }
}
