using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IEmpresaApplication
    {
        EntityEmpresa SelectByKey(KeyEmpresa oKeyEmpresa);

        IList<EntityEmpresa> Select(EntityEmpresa oEntityEmpresa);

        IList<EntityEmpresaPaginacion> SelectPagging(ref EntityEmpresaPaginacion oEntityEmpresaPaginacion);

        EntityEmpresa Insert(EntityEmpresa oEntityEmpresa);

        EntityEmpresa Update(EntityEmpresa oEntityEmpresa);

        EntityEmpresa Delete(EntityEmpresa oEntityEmpresa);
    }
}
