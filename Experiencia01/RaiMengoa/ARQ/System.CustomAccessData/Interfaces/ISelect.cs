using System;
using System.Collections.Generic;
using System.Data;

namespace System.CustomAccessData.Interfaces
{
    public interface ISelect<Entity>
    {
        IList<Entity> Select();
    }
}
