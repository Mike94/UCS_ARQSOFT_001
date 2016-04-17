using System;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace System.CustomAccessData
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
