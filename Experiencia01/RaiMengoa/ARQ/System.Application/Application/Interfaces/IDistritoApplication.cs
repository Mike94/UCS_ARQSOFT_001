using SGISystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SGISystem.Application.Application.Interfaces
{
    public interface IDistritoApplication
    {
        IList<EntityDistrito> Select(EntityDistrito oEntityDistrito);
    }
}
