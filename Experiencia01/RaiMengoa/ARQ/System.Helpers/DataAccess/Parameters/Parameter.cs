using System;
using System.Data;
using System.Data.Common;

namespace SGISystem.Helpers.DataAccess
{
    public class Parameter
    {

        public Parameter(String parameterName, Object value, DbType oDbType, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.String;
            this._direction = direction;
        }

        public Parameter(String parameterName, String value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.String;
            this._direction = direction;
        }

        public Parameter(String parameterName, Char value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.String;
            this._direction = direction;
        }

        public Parameter(String parameterName, Int32 value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.Int32;
            this._direction = direction;
        }

        public Parameter(String parameterName, DateTime value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            DateTime compare = new DateTime(1, 1, 1);

            if (value.Equals(compare))
            {
                this.Value = DBNull.Value;
                this._dbType = DbType.DateTime;
            }
            else
            {
                this.Value = value;
                this._dbType = DbType.DateTime;
            }

            this._direction = direction;
        }

        public Parameter(String parameterName, Boolean value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.Boolean;
            this._direction = direction;
        }

        public Parameter(String parameterName, Decimal value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.Decimal;
            this._direction = direction;
        }

        public Parameter(String parameterName, Byte value, ParameterDirection direction)
        {
            this.ParameterName = parameterName;
            this.Value = value;
            this._dbType = DbType.Byte;
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
