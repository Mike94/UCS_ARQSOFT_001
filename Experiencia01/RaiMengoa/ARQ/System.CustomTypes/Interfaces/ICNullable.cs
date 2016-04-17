using System;

namespace System.CustomTypes.Interfaces
{
    public interface ICNullable
    {
        Boolean IsNull { get; }
        DBNull DBNullValue { get; }
        Object NullableValue { get; }
    }
}
