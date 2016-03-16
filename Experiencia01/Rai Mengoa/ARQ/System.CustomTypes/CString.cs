using System;
using System.Data;
using System.Runtime.Serialization;

namespace System.CustomTypes
{
    [DataContract]
    public class CString : BaseType<String>
    {
        private CString(Object value) 
            : base(value)
        {
        }

        [DataMember]
        public static CString Empty
        {
            get
            {
                return new CString(String.Empty);
            }
        }


        public static CString Create(String value)
        {
            CString Customtype = new CString(value);
            return Customtype;
        }

        public static CString Create(object value)
        {
            String newValue = Convert.ToString(value);
            CString Customtype = new CString(newValue);
            return Customtype;
        }

        public static CString Create(IDataReader row, String name)
        {
            CString Customtype = new CString(row[name]);
            return Customtype;
        }
    }
}
