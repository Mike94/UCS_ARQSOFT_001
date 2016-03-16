using Microsoft.Practices.EnterpriseLibrary.Data;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace SGISystem.Helpers.DataAccess
{
    public abstract class DataEntity<TEntity>
    {
        #region //Name

        private String _name;

        public DataEntity(String nameCommon)
        {
            _name = nameCommon;
            CollectionParams = new CollectionParameter();
        }

        private String Name
        {
            get { return _name; }
        }

        private String Select
        {
            get { return String.Format("usp_{0}_select", Name); }
        }

        private String Insert
        {
            get { return String.Format("usp_{0}_insert", Name); }
        }

        private String Update
        {
            get { return String.Format("usp_{0}_update", Name); }
        }

        private String Delete
        {
            get { return String.Format("usp_{0}_delete", Name); }
        }

        #endregion

        #region //parameters

	    public CollectionParameter CollectionParams { get; set; }
	
        #endregion

        public TEntity Entity { get; set; }

        public List<TEntity> InnerSelect(CTransaction transaction)
        {
            Database objDatabase = null;
            DbTransaction objTransaction = null;

            try
            {
                if (transaction.UseTransaction)
                {
                    objDatabase = transaction.Context;
                    objTransaction = transaction.DbTransaction;
                }
                else
                {
                    objDatabase = SqlBase.Context;
                }

                using (DbCommand objCmd = objDatabase.GetStoredProcCommand(this.Select))
                {
                    this.OnSelect();

                    LoadParamaters(objDatabase, objCmd);

                    if (transaction.UseTransaction)
                    {
                        using (IDataReader objDataReader = objDatabase.ExecuteReader(objCmd, objTransaction))
                        {
                            List<TEntity> list = new List<TEntity>();
                            while (objDataReader.Read())
                            {
                                list.Add(this.InnerFill(objDataReader));
                            }
                            return list;
                        }
                    }
                    else
                    {
                        using (IDataReader objDataReader = objDatabase.ExecuteReader(objCmd))
                        {
                            List<TEntity> list = new List<TEntity>();
                            while (objDataReader.Read())
                            {
                                list.Add(this.InnerFill(objDataReader));
                            }
                            return list;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TEntity InnerInsert(CTransaction transaction)
        {
            ExecuteProcedure(transaction, this.Insert);
            return Entity;
        }

        public TEntity InnerUpdate(CTransaction transaction)
        {
            ExecuteProcedure(transaction, this.Update);
            return Entity;
        }

        public TEntity InnerDelete(CTransaction transaction)
        {
            ExecuteProcedure(transaction, this.Delete);
            return Entity;
        }

        private void ExecuteProcedure(CTransaction transaction, String action)
        {
            Database objDatabase = null;
            DbTransaction objTransaction = null;

            try
            {
                if (transaction.UseTransaction)
                {
                    objDatabase = transaction.Context;
                    objTransaction = transaction.DbTransaction;
                }
                else
                {
                    objDatabase = SqlBase.Context;
                }

                using (DbCommand objCmd = objDatabase.GetStoredProcCommand(action))
                {
                    if (action == this.Insert)
                    {
                        this.OnInsert();
                    }
                    else if (action == this.Update)
                    {
                        this.OnUpdate();
                    }
                    else if (action == this.Delete)
                    {
                        this.OnDelete();
                    }

                    LoadParamaters(objDatabase, objCmd);

                    if (transaction.UseTransaction)
                    {
                        objDatabase.ExecuteNonQuery(objCmd, objTransaction);
                        AssignReturnParamters(objCmd);
                    }
                    else
                    {
                        objDatabase.ExecuteNonQuery(objCmd);
                        AssignReturnParamters(objCmd);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AssignReturnParamters(DbCommand objCmd)
        {
            if (this.CollectionParams.Count > 0)
            {
                foreach (Parameter param in CollectionParams.Values)
                {
                    switch (param.Direction)
                    {
                        case ParameterDirection.Output:
                            param.Value = objCmd.Parameters["@" + param.ParameterName].Value;
                            break;
                        case ParameterDirection.InputOutput:
                            param.Value = objCmd.Parameters["@" + param.ParameterName].Value;
                            break;
                        case ParameterDirection.ReturnValue:
                            param.Value = objCmd.Parameters["@" + param.ParameterName].Value;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void LoadParamaters(Database objDatabase, DbCommand objCmd)
        {
            if (this.CollectionParams.Count > 0)
            {
                foreach (Parameter param in CollectionParams.Values)
                {
                    switch (param.Direction)
                    {
                        case ParameterDirection.Input:
                            objDatabase.AddInParameter(objCmd, param.ParameterName, param.DbType, param.Value);
                            break;
                        case ParameterDirection.Output:
                            objDatabase.AddOutParameter(objCmd, param.ParameterName, param.DbType, Int32.MaxValue);
                            break;
                        // POR PROBAR
                        case ParameterDirection.InputOutput:
                            objDatabase.AddInParameter(objCmd, param.ParameterName, param.DbType, Int32.MaxValue);
                            break;
                        case ParameterDirection.ReturnValue:
                            objDatabase.AddInParameter(objCmd, param.ParameterName, param.DbType, Int32.MaxValue);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private TEntity InnerFill(IDataReader datareader)
        {
           return this.Create(datareader);
        }

        #region virtuals

        protected virtual void OnSelect()
        {
            // Sobreescribir luego en cada entidad para su data access
        }

        protected virtual void OnDelete()
        {
            // Sobreescribir luego en cada entidad para su data access
        }

        protected virtual void OnInsert()
        {
            // Sobreescribir luego en cada entidad para su data access
        }

        protected virtual void OnUpdate()
        {
            // Sobreescribir luego en cada entidad para su data access
        }

        public virtual TEntity Create(IDataReader datareader)
        {
            // Sobreescribir luego en cada entidad para su data access
            throw new NotImplementedException();
        }

        #endregion

    }
}
