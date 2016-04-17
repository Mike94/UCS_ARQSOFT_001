using SGISystem.Application.Application.Interfaces;
using SGISystem.Domain.Entities;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using SGISystem.InfraStructure.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGISystem.Domain.Repository;
using SGISystem.Domain.Entities.Pagination;
using SGISystem.Domain.Entities.Keys;

namespace SGISystem.Application.Application
{
    public class DepartamentoApplication : IDepartamentoApplication
    {
        public DepartamentoApplication()
        {
            _repo = new DepartamentoRepository();
        }

        private IDepartamentoRepository _repo;

        public IDepartamentoRepository Repo
        {
            get { return _repo; }
            set { _repo = value; }
        }

        public IList<EntityDepartamento> Select(EntityDepartamento oEntityDepartamento)
        {
            try
            {
                CTransaction oCTransaction = CTransaction.Empty;
                return Repo.Select(oEntityDepartamento, oCTransaction);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
