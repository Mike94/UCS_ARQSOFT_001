﻿using SGISystem.Domain.Entities;
using SGISystem.Domain.Entities.Keys;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;

namespace SGISystem.Domain.Repository
{
    public interface IEmpresaRepository : IBaseRepository<KeyEmpresa, EntityEmpresa, EntityEmpresaPaginacion>
    {

    }
}
