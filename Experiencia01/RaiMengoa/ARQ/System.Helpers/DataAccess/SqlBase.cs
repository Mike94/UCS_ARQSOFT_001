using System;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.Serialization;

namespace SGISystem.Helpers.DataAccess
{
    public class SqlBase
    {
        public static Database Context
        {
            get { 
                SqlBase objSqlbase = new SqlBase();
                return objSqlbase.GetContextDatabase();
            }
        }

        private Database GetContextDatabase()
        {
            return new DatabaseProviderFactory().Create("DefaultConnection");
        }
    }
}
