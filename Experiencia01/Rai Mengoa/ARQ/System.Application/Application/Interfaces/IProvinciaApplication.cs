using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IProvinciaApplication
    {
        IList<EntityProvincia> Select(EntityProvincia oEntityProvincia);
    }
}
