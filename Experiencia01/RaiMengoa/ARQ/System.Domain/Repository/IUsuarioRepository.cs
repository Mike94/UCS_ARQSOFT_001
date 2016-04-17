using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Domain.Repository
{
    public interface IUsuarioRepository : IBaseRepository<KeyUsuario, EntityUsuario, EntityUsuarioPaginacion>
    {
        Boolean Autenticar(EntityUsuario oEntityUsuario);
    }
}
