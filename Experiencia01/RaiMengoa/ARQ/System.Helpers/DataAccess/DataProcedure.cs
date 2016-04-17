using Microsoft.Practices.EnterpriseLibrary.Data;
using SGISystem.Helpers.DataAccess.Transactions;
using System;
using System.Data;
using System.Data.Common;

namespace SGISystem.Helpers.DataAccess
{
    public class DataProcedure
    {
        public DataProcedure()
        {
            CollectionParams = new CollectionParameter();
        }

        #region //parameters

        public CollectionParameter CollectionParams { get; set; }

        #endregion

        public IDataReader ExecuteReader(CTransaction transaction, String action)
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
                    LoadParamaters(objDatabase, objCmd);

                    if (transaction.UseTransaction)
                    {
                        IDataReader objDataReader = objDatabase.ExecuteReader(objCmd, objTransaction);
                        _temp_DbCommand = objCmd;
                         return objDataReader;
                    }
                    else
                    {
                        IDataReader objDataReader = objDatabase.ExecuteReader(objCmd);
                        _temp_DbCommand = objCmd;                      
                        return objDataReader;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DbCommand _temp_DbCommand;

        public Int32 ExecuteProcedure(CTransaction transaction, String action)
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
                    LoadParamaters(objDatabase, objCmd);

                    if (transaction.UseTransaction)
                    {
                        int value = objDatabase.ExecuteNonQuery(objCmd, objTransaction);
                        AssignReturnParameters(objCmd);
                        return value;
                    }
                    else
                    {
                        int value = objDatabase.ExecuteNonQuery(objCmd);
                        AssignReturnParameters(objCmd);
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Object ExecuteScalar(CTransaction transaction, String action)
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
                    LoadParamaters(objDatabase, objCmd);

                    if (transaction.UseTransaction)
                    {
                        Object value = objDatabase.ExecuteScalar(objCmd, objTransaction); 
                        AssignReturnParameters(objCmd);
                        return value;
                    }
                    else
                    {
                        Object value = objDatabase.ExecuteScalar(objCmd);
                        AssignReturnParameters(objCmd);
                        return value;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AssignReturnParameters() 
        {
            AssignReturnParameters(_temp_DbCommand);
            _temp_DbCommand = null;
        }

        private void AssignReturnParameters(DbCommand objCmd)
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
    }
}
