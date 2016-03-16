using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        Boolean Autenticar(EntityUsuario oEntityUsuario);
        EntityUsuario Insert(EntityUsuario oEntityUsuario);
        EntityUsuario Update(EntityUsuario oEntityUsuario);
        EntityUsuario Delete(EntityUsuario oEntityUsuario);
        EntityUsuario SelectByKey(KeyUsuario oKeyUsuario);
        IList<EntityUsuario> Select(EntityUsuario oEntityUsuario);
        IList<EntityUsuarioPaginacion> SelectPagging(ref EntityUsuarioPaginacion oEntityUsuarioPaginacion);
    }
}
