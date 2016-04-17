using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGISystem.Helpers.DataAccess.Interfaces
{
    public interface ICTransaction
    {
        void Commit();
        void RollBack();
    }
}
