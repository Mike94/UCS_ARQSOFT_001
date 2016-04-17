using System;
using System.Collections.Generic;
using System.Data;

namespace SGISystem.Helpers.DataAccess.Interfaces
{
    public interface ISelect<Entity>
    {
        IList<Entity> Select();
    }
}
