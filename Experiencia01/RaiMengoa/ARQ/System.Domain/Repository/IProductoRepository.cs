using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGISystem.Helpers.DataAccess.Transactions;


namespace SGISystem.Domain.Repository
{
   public interface IProductoRepository : IBaseRepository<KeyProducto, EntityProducto, EntityProductoPaginacion>
    {

    }
}
