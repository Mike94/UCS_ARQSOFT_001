using System;
using System.CustomTypes.Interfaces;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class BaseType<TValue> : IBaseType, ICNullable
    {
        private Object _value;
        private Boolean _IsNull;

        public BaseType(Object pvalue)
        {
            if (pvalue == DBNull.Value || pvalue == null)
            {
                this._IsNull = true;
            }
            else
            {
                _value = (TValue) pvalue;
            }
        }

        [DataMember]
        public Boolean IsNull
        {
            get
            {
                return (null == Value || _IsNull) ? true : false;
            }
        }

        [DataMember]
        public Object Value
        {
            get { return _value; }
        }

        [DataMember]
        public DBNull DBNullValue
        {
            get { return DBNull.Value; }
        }

        [DataMember]
        public Object NullableValue
        {
            get { return (IsNull) ? null : Value; }
        }
    }
}
