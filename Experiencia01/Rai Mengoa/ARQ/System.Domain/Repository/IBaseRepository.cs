using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Domain.Repository
{
    public interface IBaseRepository<Tkey, TValue, TValuePaginacion>
    {
        TValue SelectByKey(Tkey okey, CTransaction oCTransaction);
        IList<TValue> Select(TValue oValue, CTransaction oCTransaction);
        IList<TValuePaginacion> SelectPagging(ref TValuePaginacion oValuePaginacion);
        TValue Insert(TValue oValue, CTransaction oCTransaction);
        TValue Update(TValue oValue, CTransaction transaction);
        TValue Delete(TValue oValue, CTransaction transaction);
    }
}
