using System;
using System.Data;
using System.Data.Common;

namespace System.CustomAccessData
{
    public class Parameter
    {
        public Parameter(String parameterName, String value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this._dbType = DbType.String;
            this._direction = direction;
        }

        public Parameter(String parameterName, Int32 value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;

            this._dbType = DbType.Int32;
            this._direction = direction;
        }

        public Parameter(String parameterName, DateTime value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this._dbType = DbType.DateTime;
            this._direction = direction;
        }

        public Parameter(String parameterName, Boolean value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this._dbType = DbType.Boolean;
            this._direction = direction;
        }

        private DbType _dbType;

        public DbType DbType { get { return _dbType; } }

        private ParameterDirection _direction;

        public ParameterDirection Direction { get { return _direction; } }

        public String ParameterName { get; set; }

        public object Value { get; set; }
    }
}
