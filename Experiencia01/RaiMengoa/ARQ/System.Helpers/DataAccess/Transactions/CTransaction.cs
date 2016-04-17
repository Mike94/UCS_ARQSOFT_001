using Microsoft.Practices.EnterpriseLibrary.Data;
using SGISystem.Helpers.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;

namespace SGISystem.Helpers.DataAccess.Transactions
{
    public class CTransaction : ICTransaction
    {
        private CTransaction()
        {

        }

        private CTransaction Transaction  { get; set; }

        public bool UseTransaction { get; private set; }

        public static CTransaction Empty
        {
            get 
            {
                CTransaction objtransaction = new CTransaction();
                objtransaction.UseTransaction = false;
                return objtransaction;
            }
        }

        public static CTransaction Full
        {
            get
            {
                CTransaction objtransaction = new CTransaction();
                objtransaction.UseTransaction = true;
                return objtransaction;
            }
        }

        public DbTransaction _dbTransaction;

        public DbTransaction DbTransaction 
        { 
            get 
            {
                return (_dbTransaction != null) ? _dbTransaction : null;
            }
        }

        private Database _context;

        public Database Context
        {
            get
            {
                if (this._context == null)
                {
                    this._context = SqlBase.Context;
                    DbConnection objconnection = this._context.CreateConnection();
                    objconnection.Open();
                    this._dbTransaction = objconnection.BeginTransaction();
                }
                return this._context;
            }
            set { _context = value; }
        }

        public void Commit()
        {
            this.DbTransaction.Commit();
        }

        public void RollBack()
        {
            if (this.DbTransaction != null)
            {
                this.DbTransaction.Rollback();
            }
        }

    }
}
